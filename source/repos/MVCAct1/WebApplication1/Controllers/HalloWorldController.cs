using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HalloWorldController : Controller
    {
        public IActionResult Index(PersonModel personModel)
        {
            string welcomeString = "";
        if (personModel.Name !=""&& personModel.Surname !=null)
                welcomeString = "Welcome" +
                 Console.WriteLine(welcomeString);
            return this.View();
        }
    }
}
