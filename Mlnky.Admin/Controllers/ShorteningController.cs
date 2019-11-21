using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Mlnky.Admin.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Mlnky.Admin.Controllers
{
    public class ShorteningController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ShorteningController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Shorten(ShorteningRequestViewModel request)
        {
            var client = _httpClientFactory.CreateClient();

            var uri = new Uri("https://localhost:44381/api/shortening");

            var formContent = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("LongUrl", request.LongUrl),
                new KeyValuePair<string, string>("BaseUrl", "https://localhost:44348")
            });

            Task<string> response = client.PostAsync(uri, formContent)
                .Result
                .Content
                .ReadAsStringAsync();

            var jObject = JObject.Parse(response.Result);
            var shortenedUrl = jObject.GetValue("shortenedUrl");

            var model = new ShorteningResponseViewModel();
            model.ShortUrl = shortenedUrl.ToString();

            return View(model);
        }
    }
}