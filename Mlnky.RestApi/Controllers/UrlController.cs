using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mlnky.Business.Services;
using Mlnky.Business.Services.Implementations;

namespace Mlnky.RestApi.Controllers
{
    [Route("api/Url")]
    [ApiController]
    public class UrlController : ControllerBase
    {
        // GET api/values/5
        [HttpGet("{url}")]
        public ActionResult<string> Get(string url)
        {
            IRedirectingService myService = new RedirectingService();
            var result = myService.GetLongUrl(url);
            return result;
        }
    }
}