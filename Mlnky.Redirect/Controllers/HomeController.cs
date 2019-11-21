using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Mlnky.Redirect.Models;

namespace Mlnky.Redirect.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public HomeController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [HttpGet("{url}")]
        public IActionResult Index(string url)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, "https://localhost:44381/api/url/" + url);
            var client = _httpClientFactory.CreateClient();
            var response = client.SendAsync(request).Result;

            if(response.IsSuccessStatusCode)
            {
                var longUrl = response.Content.ReadAsStringAsync().Result;
                return Redirect(longUrl);
            }
            else
            {
                return BadRequest();
            }         
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
