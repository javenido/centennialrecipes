using CentennialRecipes.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CentennialRecipes.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index() => View();
    }
}