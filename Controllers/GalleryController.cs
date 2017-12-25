using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ImageSPA.Models;
using Microsoft.AspNetCore.Mvc;

namespace ImageSPA.Controllers
{
    public class GalleryController : Controller
    {
        public IActionResult Index()
        {
            var model = new GalleryIndexModel();
            return View();
        }
    }
}