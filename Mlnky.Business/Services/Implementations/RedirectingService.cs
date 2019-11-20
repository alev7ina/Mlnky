using Mlnky.Common.Repositories;
using Mlnky.DataAccess.MangoDB.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mlnky.Business.Services
{
    public class RedirectingService : IRedirectingService
    {
        private readonly IShorteningsRepository _shorteningsRepository;

        public RedirectingService(IShorteningsRepository shorteningsRepository)
        {
            _shorteningsRepository = shorteningsRepository;
        }

        public string GetLongUrl(string shortCode)
        {
            var converter = new Base62.Base62Converter();
            var decode = converter.Decode(shortCode);
            if (!long.TryParse(decode, out long shortKey))
            {
                throw new ArgumentException("Can't convert");
            }

            var result = _shorteningsRepository.FindOne(shortKey);
            return result.LongUrl;
        }
    }
}
