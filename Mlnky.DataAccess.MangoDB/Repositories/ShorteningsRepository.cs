using Mlnky.Common.Entities;
using Mlnky.Common.Repositories;
using Mlnky.DataAccess.MangoDB.Models;
using MongoDB.Driver;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Mlnky.DataAccess.MangoDB.Repositories
{
    public class ShorteningsRepository : IShorteningsRepository
    { 
        public Shortening FindOne(long shortKey)
        {
            var client = new MongoClient("mongodb+srv://mlnky:865c9Mv%40bJ%5E-%2BZ3L@cluster0-zkipe.mongodb.net/test?retryWrites=true&w=majority");
            var database = client.GetDatabase("test");
            var collection = database.GetCollection<ShorteningModel>("Shortenings");

            ShorteningModel model = collection.Find(x => x.ShortKey == shortKey).FirstOrDefault();
            var result = new Shortening();
            result.ShortKey = model.ShortKey;
            result.LongUrl = model.LongUrl;
            return result;
        }

        public long GetNextId()
        {
            var client = new MongoClient("mongodb+srv://mlnky:865c9Mv%40bJ%5E-%2BZ3L@cluster0-zkipe.mongodb.net/test?retryWrites=true&w=majority");
            var database = client.GetDatabase("test");
            var collection = database.GetCollection<ShorteningModel>("Shortenings");

            if (!collection.AsQueryable().Any())
            {
                return 1;
            }
            var model = collection.AsQueryable().OrderByDescending(x => x.ShortKey).FirstOrDefault();
            return model.ShortKey + 1;
        }

        public void Save(Shortening shortening)
        {
            var client = new MongoClient("mongodb+srv://mlnky:865c9Mv%40bJ%5E-%2BZ3L@cluster0-zkipe.mongodb.net/test?retryWrites=true&w=majority");
            var database = client.GetDatabase("test");
            var collection = database.GetCollection<ShorteningModel>("Shortenings");

            var model = new ShorteningModel();
            model.LongUrl = shortening.LongUrl;
            model.ShortKey = shortening.ShortKey;

            collection.InsertOne(model);
        }
    }
}
