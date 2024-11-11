using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController]
    public class CitiesController : ControllerBase
    {

        public JsonResult GetCities()
        {

            return new JsonResult(

                new List<object> {

                    new { id = 1 , name = "Dhaka" },
                    new { id = 2 , name = "Rajshahi" }

                });

        }

    }
}
