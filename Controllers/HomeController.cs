using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.NodeServices;

namespace aspnetcore_angular.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Chart([FromServices]INodeServices nodeService)
        {
            // var options = new {
            //     width = 400, height = 200, 
            //     showArea = true, showPoint = true, fullWidth = true
            // };

            // var data = new {
            //     label = new[] { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat"},
            //     series = new[] {
            //         new[] {2,5,3,8,2,5},
            //         new[] {3,6,8,2,5,8},
            //         new[] {3,6,8,3,7,4}
            //     }
            // }; 
            ViewData["ResultFromNode"] = await nodeService.InvokeAsync<string>("chartModule.js"); //,"line", options, data);
            return View();
        }

        public IActionResult Error()
        {
            ViewData["RequestId"] = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
            return View();
        }
    }
}
