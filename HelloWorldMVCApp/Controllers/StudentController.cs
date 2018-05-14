using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorldMVCApp.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index => View();
    }
}