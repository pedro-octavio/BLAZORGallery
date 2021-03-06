﻿using System;

namespace BLAZORGallery.Domain.Models
{
    public class ImageModel
    {
        public ImageModel(string id, string imageSRC, DateTime createDate)
        {
            Id = id;
            ImageSRC = imageSRC;
            CreateDate = createDate;
        }

        public ImageModel()
        {
            Id = Guid.NewGuid().ToString().Replace("-", string.Empty).Substring(0, 10);
            CreateDate = DateTime.Now;
        }

        public string Id { get; set; }
        public string ImageSRC { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
