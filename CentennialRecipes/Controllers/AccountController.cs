using CentennialRecipes.Models;
using CentennialRecipes.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CentennialRecipes.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private UserManager<IdentityUser> userManager;
        private SignInManager<IdentityUser> signInManager;

        public AccountController(UserManager<IdentityUser> userMgr,
            SignInManager<IdentityUser> signInMgr)
        {
            userManager = userMgr;
            signInManager = signInMgr;
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login(string returnUrl)
        {
            // if user is already signed in, redirect to returnUrl or home page
            if (User.Identity.IsAuthenticated)
            {
                TempData["message"] = "You're already signed in.";
                return Redirect(returnUrl ?? "/");
            }

            return View(new LoginViewModel { ReturnUrl = returnUrl });
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel loginModel)
        {
            if (ModelState.IsValid)
            {
                IdentityUser user = await userManager.FindByNameAsync(loginModel.Name);
                if (user != null)
                {
                    if ((await signInManager
                        .PasswordSignInAsync(user, loginModel.Password, false, false))
                        .Succeeded)
                    {
                        if (user.UserName == "Admin") // if admin logged in, redirect to admin landing page
                        {
                            TempData["message"] = "Signed in as Administrator."; // set alert
                            return RedirectToAction("Index", "Admin");
                        }

                        // otherwise, redirect to returnUrl
                        TempData["message"] = $"Welcome back, {user.UserName}.";
                        return Redirect(loginModel.ReturnUrl ?? "/");
                    }
                    ModelState.AddModelError("", "Incorrect password"); // unreachable if sign-in is valid
                }
                else // user not found
                {
                    ModelState.AddModelError("", "User name does not exist");
                }
            }

            return View(loginModel);
        }

        public async Task<RedirectResult> Logout(string returnUrl = "/")
        {
            await signInManager.SignOutAsync();
            TempData["message"] = "Signed out.";
            return Redirect(returnUrl);
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult SignUp(string returnUrl)
        {
            // if user is already signed in, redirect to returnUrl or home page
            if (User.Identity.IsAuthenticated)
            {
                TempData["message"] = "You already have an account.";
                return Redirect(returnUrl ?? "/");
            }

            return View(new RegisterViewModel { ReturnUrl = returnUrl });
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SignUp(RegisterViewModel registerViewModel)
        {
            if (ModelState.IsValid)
            {
                IdentityUser user = new IdentityUser(registerViewModel.Name);
                IdentityResult result = await userManager.CreateAsync(user, registerViewModel.Password);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, "User");
                    await signInManager.SignInAsync(user, false);
                    TempData["message"] = $"Account creation successful. Welcome to Centennial Recipes, {user.UserName}.";
                    return Redirect(registerViewModel.ReturnUrl ?? "/");
                }

                // retrieve all error messages
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }

            return View(registerViewModel);
        }
    }
}