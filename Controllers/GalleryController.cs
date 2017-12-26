using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ImageSPA.Models;
using Microsoft.AspNetCore.Mvc;
using SimpleImageGallery.Data.Models;
using ImageSPA.Models;

namespace ImageSPA.Controllers
{
    public class GalleryController : Controller
    {
        public IActionResult Index()
        {
            var hikingImageTags = new List<ImageTag>();
            var cityImageTags = new List<ImageTag>();

            var tag1 = new ImageTag()
            {
                Description = "Adventure",
                Id = 0
            };
            var tag2 = new ImageTag()
            {
                Description = "Urban",
                Id = 1
            };
            var tag3 = new ImageTag()
            {
                Description = "New York",
                Id = 2
            };
            hikingImageTags.Add(tag1);
            cityImageTags.AddRange(new List<ImageTag>{ tag2, tag3 });
            var imageList = new List<GalleryImage>()
            {
                new GalleryImage()
                {
                    Title = "Hiking Trip",
                    Url = "https://images.pexels.com/photos/404960/pexels-photo-404960.jpeg",
                    Created = DateTime.Now,
                    Tags = hikingImageTags
                },

                new GalleryImage()
                {
                    Title = "On the Trail",
                    Url = "https://images.pexels.com/photos/69743/pexels-photo-69743.jpeg",
                    Created = DateTime.Now,
                    Tags = hikingImageTags
                },

                new GalleryImage()
                {
                    Title = "Downtown",
                    Url = "https://images.pexels.com/photos/164583/pexels-photo-164583.jpeg",
                    Created = DateTime.Now,
                    Tags = cityImageTags
                }
            };
            var model = new GalleryIndexModel()
            {
                Images = imageList,
                SearchQuery = ""
        };
            return View(model);
        }
    }
}