using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mlnky.DataAccess.MangoDB.Models
{
    public class ShorteningModel
    {
        public ObjectId Id { get; set; }
        public string LongUrl { get; set; }
        public string ShortUrl { get; set; }
    }
}
