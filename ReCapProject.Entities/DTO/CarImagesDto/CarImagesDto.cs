using Core.Entities;
using ReCapProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReCapProject.Entities.DTO.CarImagesDto
{
    public class CarImagesDto:IDto
    {
        public string Img1 { get; set; }
        public string Img2 { get; set; }
        public string Img3 { get; set; }
        public string Img4 { get; set; }
        public string Img5 { get; set; }
        public int CarId { get; set; }

    }
}
