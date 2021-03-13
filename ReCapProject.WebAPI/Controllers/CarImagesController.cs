using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReCapProject.Business.Abstract;
using ReCapProject.Entities.Concrete;

namespace ReCapProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarImagesController : ControllerBase
    {
        ICarImageService _carImageService;
     
        public CarImagesController(ICarImageService carImageService)
        {
            _carImageService = carImageService;
           
        }
        [HttpPost("add")]
        public IActionResult Add(List<IFormFile> files)
        {
           CarImage carImage = Image();
             var result = _carImageService.Add(carImage,files);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        private static CarImage Image()
        {
            return new CarImage();
        }
    }
}

