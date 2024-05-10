using Buisness.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;


namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarImagesController : ControllerBase
    {

        ICarImageService  _carImageService;

        public CarImagesController(ICarImageService carImageService)
        {
        
            _carImageService = carImageService; 
        
        }

        [HttpPost("add")]
        public IActionResult Add([FromForm] IFormFile file ,[FromForm] CarImages carImages)
        {
            var result = _carImageService.Add(file,carImages);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }

    }
}
