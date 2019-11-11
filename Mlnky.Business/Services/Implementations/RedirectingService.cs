using Mlnky.Common.Repositories;
using Mlnky.DataAccess.MangoDB.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mlnky.Business.Services.Implementations
{
    public class RedirectingService : IRedirectingService
    {

        public string GetLongUrl(string shortCode)
        {
            IShorteningsRepository myRepo = new ShorteningsRepository();
            var result = myRepo.FindOne(shortCode);
            return result.LongUrl;
        }
    }
}
