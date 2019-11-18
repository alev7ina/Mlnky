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
    [Route("api/Url")]
    [ApiController]
    public class UrlController : ControllerBase
    {
        private readonly IRedirectingService _redirectingService;

        public UrlController(IRedirectingService redirectingService)
        {
            _redirectingService = redirectingService;
        }
        // GET api/values/5
        [HttpGet("{url}")]
        public ActionResult<string> Get(string url)
        {
            var result = _redirectingService.GetLongUrl(url);
            return result;
        }
        
    }
}