﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SimpleImageGallery.Data.Models;

namespace ImageSPA.Models
{
    public class GalleryIndexModel
    {
        public IEnumerable<GalleryImage> Images { get; set; }
        public string SearchQuery { get; set; }
        
    }
}
