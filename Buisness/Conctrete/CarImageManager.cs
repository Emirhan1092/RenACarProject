using Buisness.Abstract;
using Buisness.Constants;
using Core.Utilities.Buisness;
using Core.Utilities.Helpers.FileHelper;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;

namespace Buisness.Conctrete
{
    public class CarImageManager : ICarImageService
    {
        ICarImageDal _carImageDal;
        IFileHelperService _fileHelperService;

        public CarImageManager(ICarImageDal carImageDal, IFileHelperService fileHelperService)
        {
            _carImageDal = carImageDal;
            _fileHelperService = fileHelperService;

        }

        public IResult Add(IFormFile file, CarImages carImage)
        {
            IResult result = BuisnessRules.Run(CheckForCarImageLimit(carImage.CarId));
            if (result != null)
            {
                return result;
            
            }

            carImage.ImagePath = _fileHelperService.Upload(file, PathConstants.CarImagesPath);
            carImage.ImageDate = DateTime.Now;

            _carImageDal.Add(carImage);
            return new SuccessResult(Messages.ImageAdded);
        
        
        }

       

        public IResult Delete(CarImages carImage)
        {
            _fileHelperService.Delete(PathConstants.CarImagesPath + carImage.ImagePath);    
           _carImageDal.Delete(carImage);   

            return new SuccessResult(Messages.CarImageDeleted);
        
        }

        public IDataResult<List<CarImages>> GetAll()
        {
            return new SuccesDataResult<List<CarImages>>(_carImageDal.GetAll(), Messages.ImageListed);
        }

        public IDataResult<CarImages> GetById(int id)
        {
            return new SuccesDataResult<CarImages>(_carImageDal.Get(i => i.Id == id), Messages.ImageListedById);
        }

        public IDataResult<List<CarImages>> GetImagesByCarId(int carId)
        {
            IResult result = BuisnessRules.Run(CheckImgeExists(carId));
            if(result !=null) 
            
            {

                return new ErrorDataResult<List<CarImages>>(GetDefaultImage(carId).Data);
            }
            return new SuccesDataResult<List<CarImages>>(_carImageDal.GetAll(c => c.CarId == carId), Messages.ImageListedById);
        }

        private IDataResult<List<CarImages>> GetDefaultImage(int carId)
        {
            List<CarImages> carImages = new List<CarImages>();  
            carImages.Add(new CarImages {  CarId = carId , ImageDate= DateTime.Now,
            ImagePath = "DefaultImage.jpg"});
            return new SuccesDataResult<List<CarImages>>(carImages);
        }

        public IResult Update(IFormFile file, CarImages carImage)
        {
            carImage.ImagePath = _fileHelperService.Update(file, PathConstants.CarImagesPath + carImage.ImagePath,
             PathConstants.CarImagesPath);
            carImage.ImageDate = DateTime.Now;
            return new SuccessResult(Messages.ImaageUpdated);
        
        
        }
        private IResult CheckForCarImageLimit(int carId)
        {
            var result = _carImageDal.GetAll(i => i.CarId == carId).Count;
           if(result>5)
            {
                return new ErrorResult(Messages.CarImageLimitReached);
            }
            return new SuccessResult();
        
        }
       

        private IResult CheckImgeExists(int carId)
        {
          var result = _carImageDal.GetAll(i=>i.CarId == carId).Count;
           
          if(result>0)
            {

                return new ErrorResult(Messages.CarImageAlreadyHave);

            }

            return new SuccessResult();

           

         }

    }
}

