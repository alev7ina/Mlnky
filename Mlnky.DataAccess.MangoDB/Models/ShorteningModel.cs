using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mlnky.DataAccess.MangoDB.Models
{
    public class ShorteningModel
    {
        public ObjectId Id { get; set; }
        public long ShortKey { get; set; }
        public string LongUrl { get; set; }
    }
}
