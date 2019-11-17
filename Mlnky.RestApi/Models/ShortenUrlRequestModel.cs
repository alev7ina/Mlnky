using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mlnky.RestApi.Models
{
    public class ShortenUrlRequestModel
    {
        public string LongUrl { get; set; }
        public string BaseUrl { get; set; }
    }
}
