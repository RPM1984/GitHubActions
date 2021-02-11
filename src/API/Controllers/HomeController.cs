using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("")]
    public class HomeController : ControllerBase
    {
        private readonly AppDetails _appDetails;

        public HomeController(AppDetails appDetails)
        {
            _appDetails = appDetails;
        }

        [HttpGet]
        public string Get() => _appDetails.ToString();
    }
}
