﻿namespace KestenTestApp.Models
{
    public class Image
    {
        public int ImageId { get; set; }
        public string FileName { get; set; } = default!;
        public List<Variety> Varieties { get; set; } = new List<Variety>();
    }
}