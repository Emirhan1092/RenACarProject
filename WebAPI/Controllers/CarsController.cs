using Buisness.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        ICarService _carService;

        public CarsController (ICarService carService)
        {
            _carService = carService;   
        }

        [HttpGet("getall")]

        public IActionResult GetAll()
        {
            var result = _carService.GetAll();  
            if(result.Success)
            {
                return Ok(result.Data);  
            }
            return BadRequest(result.Message);    

        }

        [HttpGet("getbyid")] 
        public   IActionResult GetById(int carid)
        {
            var result = _carService.GetById(carid);
            if(result.Success)
            {
                return Ok(result.Data);
            }
            return  BadRequest(result.Message);
        }


        [HttpGet("add")]

        public IActionResult Add(Car car)
        {
            var result = _carService.Add(car);
            if(result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);  
        }

        [HttpGet("getbycolorId")]
        public IActionResult GetCarsBrandId(int brandid)
        {
            var result = _carService.GetCarsBrandId(brandid);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("getbycolorId")]
        public IActionResult GetByColorId(int colorid)
        {
            var result = _carService.GetById(colorid);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("getcardetails")]
        public IActionResult GetCarDetails()
        {
            var result = _carService.GetCarDetails();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }
      
    }
}
