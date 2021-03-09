using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Builder.Internal;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CentennialRecipes.Models
{
    public static class IdentitySeedData
    {
        private const string ADMIN_NAME = "Admin";
        private const string ADMIN_PASSWORD = "Group#8";
        private const string ROLE_NAME_ADMIN = "Admin";
        private const string ROLE_NAME_USER = "User";
        private const string NAME1 = "avenido";
        private const string NAME2 = "pacleb";
        private const string NAME3 = "torceno";
        private const string PASSWORD1 = "Group#8john";
        private const string PASSWORD2 = "Group#8kristine";
        private const string PASSWORD3 = "Group#8hanzel";

        public static async void EnsurePopulated(IApplicationBuilder app)
        {
            // Role and User managers
            RoleManager<IdentityRole> roleManager = app.ApplicationServices
                .GetRequiredService<RoleManager<IdentityRole>>();
            UserManager<IdentityUser> userManager = app.ApplicationServices
                .GetRequiredService<UserManager<IdentityUser>>();

            // create the Admin role
            IdentityRole adminRole = await roleManager.FindByNameAsync(ROLE_NAME_ADMIN);
            if (adminRole == null)
            {
                adminRole = new IdentityRole(ROLE_NAME_ADMIN);
                await roleManager.CreateAsync(adminRole);
            }

            // create the User role
            IdentityRole userRole = await roleManager.FindByNameAsync(ROLE_NAME_USER);
            if (userRole == null)
            {
                userRole = new IdentityRole(ROLE_NAME_USER);
                await roleManager.CreateAsync(userRole);
            }

            // create Admin user
            IdentityUser admin = await userManager.FindByNameAsync(ADMIN_NAME);
            if (admin == null)
            {
                admin = new IdentityUser(ADMIN_NAME);
                await userManager.CreateAsync(admin, ADMIN_PASSWORD);
                await userManager.AddToRoleAsync(admin, ROLE_NAME_ADMIN);
            }

            // create the first 3 users
            IdentityUser user1 = await userManager.FindByNameAsync(NAME1);
            if (user1 == null)
            {
                user1 = new IdentityUser(NAME1);
                await userManager.CreateAsync(user1, PASSWORD1);
                await userManager.AddToRoleAsync(user1, ROLE_NAME_USER);
            }

            IdentityUser user2 = await userManager.FindByNameAsync(NAME2);
            if (user2 == null)
            {
                user2 = new IdentityUser(NAME2);
                await userManager.CreateAsync(user2, PASSWORD2);
                await userManager.AddToRoleAsync(user2, ROLE_NAME_USER);
            }

            IdentityUser user3 = await userManager.FindByNameAsync(NAME3);
            if (user3 == null)
            {
                user3 = new IdentityUser(NAME3);
                await userManager.CreateAsync(user3, PASSWORD3);
                await userManager.AddToRoleAsync(user3, ROLE_NAME_USER);
            }
        }
    }
}