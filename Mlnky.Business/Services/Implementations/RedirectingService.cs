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
            var result = _shorteningsRepository.FindOne(shortCode);
            return result.LongUrl;
        }
    }
}
