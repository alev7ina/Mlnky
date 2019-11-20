using Mlnky.Common.Entities;
using Mlnky.Common.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mlnky.Business.Services
{
    public class ShorteningService : IShorteningService
    {
        private readonly IShorteningsRepository _shorteningsRepository;

        public ShorteningService(IShorteningsRepository shorteningsRepository)
        {
            _shorteningsRepository = shorteningsRepository;
        }

        public string Shorten(string longUrl, string baseUrl)
        {
            var nextId = _shorteningsRepository.GetNextId();

            var converter = new Base62.Base62Converter();
            var encode = converter.Encode(nextId.ToString());

            var newShortening = new Shortening();
            newShortening.LongUrl = longUrl;
            newShortening.ShortKey = nextId;

            _shorteningsRepository.Save(newShortening);

            var result = baseUrl + "/" + encode;

            return result;
        }
    }
}
