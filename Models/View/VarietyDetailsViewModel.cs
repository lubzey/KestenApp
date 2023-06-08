using Azure.Core;
using Microsoft.AspNetCore.Hosting.Server;
using System;

namespace KestenTestApp.Models.View
{
    public class VarietyDetailsViewModel
    {
        public Variety Variety;
        public string Title;
        public string ThumbnailImage;

        public VarietyDetailsViewModel(Variety variety)
        {
            this.Variety = variety;
            this.Title = variety.VarietyName;
            this.ThumbnailImage = variety.Images.Any()
                ? $"/Images/Varieties/{variety.VarietyId}/{variety.Images.First().FileName}.jpg"
                : $"/Images/no-image.jpg";
        }
    }
}
