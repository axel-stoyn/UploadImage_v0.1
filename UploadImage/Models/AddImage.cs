using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UploadImage.Models
{
    public class AddImage
    {
        public int ID { get; set; }
        //[Display(Name = "Name")]
        public string ImagePath { get; set; }
        public string Description { get; set; }

        public string Manufactures { get; set; }
        public string Model { get; set; }

        //[Display(Name = "Date and Time")]
        //public DateTime Intime { get; set; }

        public string Compression { get; set; }

        [Display(Name = "Exposure Time")]
        public int Exposure { get; set; }

        [Display(Name = "Exif Version")]
        public double ExifVersion { get; set; }

    }
}