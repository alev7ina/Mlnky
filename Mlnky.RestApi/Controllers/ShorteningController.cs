using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mlnky.Business.Services;
using Mlnky.RestApi.Models;

namespace Mlnky.RestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShorteningController : ControllerBase
    {
        private readonly IShorteningService _shorteningService;
         public ShorteningController(IShorteningService shorteningService)
        {
            _shorteningService = shorteningService;
        }

        // POST api/values
        [HttpPost]
        public ActionResult<ShortenUrlResponseModel> Post([FromForm] ShortenUrlRequestModel request)
        {
            string ShortUrl = _shorteningService.Shorten(request.LongUrl, request.BaseUrl);
            
            ShortenUrlResponseModel model = new ShortenUrlResponseModel();
            model.ShortenedUrl = ShortUrl;

            return model;
        }
    }

}