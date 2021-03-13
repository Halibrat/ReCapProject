using Core.Utilities.Business;
using Core.Utilities.Results;
using Grpc.Core;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using ReCapProject.Business.Abstract;
using ReCapProject.Business.Constans;
using ReCapProject.DataAccess.Abstract;
using ReCapProject.Entities.Concrete;
using ReCapProject.Entities.DTO.CarImagesDto;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ReCapProject.Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
        ICarImageDal _carImageDal;
        private IHostingEnvironment _hostingEnvironment;
        public CarImageManager(ICarImageDal carImageDal, IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
            _carImageDal = carImageDal;
        }

        public IResult Add(CarImage carImage,List<IFormFile> files)
        {
            //IResult result = BusinessRules.Run(UploadCarPhoto(carImages));
            //if (result != null)
            //{
            //    return result;
            //}

            CarImagesDto photos = UploadCarPhoto(files,carImage);
            carImage.ImagePath = photos.Img1;
            carImage.ImagePath = photos.Img2;
            carImage.ImagePath = photos.Img3;
            carImage.ImagePath = photos.Img4;
            carImage.ImagePath = photos.Img5;
            
    
      
            _carImageDal.Add(carImage);
            
            return new SuccessResult();
        }

        public IResult Delete(CarImage carImage)
        {
            _carImageDal.Delete(carImage);
            return new SuccessResult();
        }

        public IDataResult<List<CarImage>> GetAll()
        {
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll());
        }

        public IDataResult<List<CarImage>> GetById(int id)
        {
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll(ci => ci.CarId == id));
        }

        public IResult Update(CarImage carImage)
        {
            _carImageDal.Update(carImage);
            return new SuccessResult();
        }  


        private CarImagesDto UploadCarPhoto(List<IFormFile> files,CarImage carImage)
        {
           
            CarImagesDto carImgList = new CarImagesDto();
           
         
            if (files.Count >=1 && files.Count<6)
            {
                
                foreach (var item in files)
                {
                   
                    var uniqueFileName =GetUniqueFileName(item.FileName);
                    _hostingEnvironment.ContentRootPath = Path.Combine(Directory.GetCurrentDirectory(), "Images");
                    var uploads = Path.Combine(_hostingEnvironment.ContentRootPath);
                    var filePath = Path.Combine(uploads, uniqueFileName);
                    item.CopyTo(new FileStream(filePath, FileMode.OpenOrCreate));
                    if (carImgList.Img1 == null)
                    {
                        carImgList.Img1 = uniqueFileName;
                     
                    }
                    else if (carImgList.Img2 == null)
                    {
                        carImgList.Img2 = uniqueFileName;
                    }
                    else if (carImgList.Img3 == null)
                    {
                        carImgList.Img3 = uniqueFileName;
                    }
                    else if (carImgList.Img4 == null)
                    {
                        carImgList.Img4 = uniqueFileName;
                    }
                    else if (carImgList.Img5 == null)
                    {
                        carImgList.Img5 = uniqueFileName;
                    }
                   
                  
                }
               
                return carImgList; 
            }
            else if (files.Count < 1)
            {
                carImgList.Img1 = "\\Images\\1_UL9RWkTUtJlyHW7kGm20hQ.png";
                return carImgList;
            }
            else
            {
                Exception ex = new Exception("Araç görseli beşten fazla olamaz");
                throw ex;
            }
               
        }

        private string GetUniqueFileName(string fileName)
        {
            fileName = Path.GetFileName(fileName);
            return Path.GetFileNameWithoutExtension(fileName)
                + "_"
                + Guid.NewGuid().ToString().Substring(0,12)
                + Path.GetExtension(fileName);
        }


    }
}



