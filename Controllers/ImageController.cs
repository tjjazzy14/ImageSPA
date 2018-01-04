using ImageSPA.Models;
using Microsoft.AspNetCore.Mvc;

namespace ImageSPA.Controllers
{
    public class ImageController : Controller
    {
        public IActionResult Upload()
        {
            var model = new UploadImageModel();
            return View(model);
        }
        [HttpPost]
        public IActionResult UploadNewImage()
        {
            return Ok();
        }
    }
}