using System;
using System.Collections.Generic;
using System.Text;

namespace Mlnky.Common.Entities
{
    public class Shortening
    {
        public long ShortKey { get; set; }
        public string LongUrl { get; set; }
        public string ShortUrl { get; set; }            
    }
}
