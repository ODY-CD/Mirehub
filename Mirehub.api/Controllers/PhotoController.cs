using Microsoft.AspNetCore.Mvc;
using Mirehub.api.Services;
using System.Net;

namespace Mirehub.api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PhotoController : ControllerBase
    {
        private readonly ILogger<PhotoController> _logger;
        private readonly IStorageService _storageService;

        public PhotoController(ILogger<PhotoController> logger,
            IStorageService storageService)
        {
            _logger = logger;
            _storageService = storageService;
        }

        [HttpPost(Name = "AddPhoto")]
        public HttpResponseMessage Post(IFormFile file, string idEvent)
        {
            _storageService.Upload(file, idEvent);
            return new HttpResponseMessage(System.Net.HttpStatusCode.Created);
        }

        [HttpGet(Name = "GetAllPhotoFromEvent")]
        public List<string> GetAllPhoto(int idEvent)
        {
            return null;
        }
    }
}