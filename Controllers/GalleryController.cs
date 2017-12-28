using ImageSPA.Models;
using Microsoft.AspNetCore.Mvc;
using SimpleImageGallery.Data;
using System.Linq;

namespace ImageSPA.Controllers
{
    public class GalleryController : Controller
    {
        private readonly IImage _imageService;

        public GalleryController(IImage imageService)
        {
            _imageService = imageService;
        }
        public IActionResult Index()
        {

            var imageList = _imageService.GetAll();
            var model = new GalleryIndexModel()
            {
                Images = imageList,
                SearchQuery = ""
            };
            return View(model);
        }

         public IActionResult Detail (int id)
        {
            var image = _imageService.GetbyId(id);
            var model = new GalleryDetailModel()
            {
                Id = image.Id,
                Title = image.Title,
                CreatedOn = image.Created,
                Url = image.Url,
                Tags = image.Tags.Select(t => t.Description).ToList()
    
            };
            return View(model);
        }

       /*var hikingImageTags = new List<ImageTag>();
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
        //hikingImageTags.Add(tag1);
        //cityImageTags.AddRange(new List<ImageTag>{ tag2, tag3 });
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
        };*/

    }
}