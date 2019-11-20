using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Mlnky.Admin.Models;

namespace Mlnky.Admin.Controllers
{
    public class ShorteningController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Shorten(ShorteningRequestViewModel request)
        {
            var model = new ShorteningResponseViewModel();
            model.ShortUrl = request.LongUrl;

            return View(model);
        }
    }
}