using System;
using System.Collections.Generic;
using System.Text;

namespace Mlnky.Business.Services
{
    public class ShorteningService : IShorteningService
    {
        public string Shorten(string longUrl, string baseUrl)
        {
            return baseUrl + "/" + "bloobloo";
        }
    }
}
