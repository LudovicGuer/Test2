
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorld.Test
{
    
    public class Test:Controller
    {
        public string Index()
        {
            return "hello from TEST controller";
        }

        public string About()
        {
            return "About us";
        }

       public ActionResult Contact()
        {
            return View();
        }
    }
}
