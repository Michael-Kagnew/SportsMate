using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsMate.Controllers
{
    public class AdminController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }


        //TODO figure out how to remove user; will call adminRespoitory delete method here
        public IActionResult RemoveUser()
        {

        }
    }
}
