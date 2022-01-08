using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class PersonModel : Controller
    {
       private MySqlConnection con 
            = new MySqlConnection("Data Source-localhost;User ID=root;Database=dotnet2")
    }
}
