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
            return baseUrl + "/" + "bloobloo";
        }
    }
}
