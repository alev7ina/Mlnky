using System;
using System.Collections.Generic;
using System.Text;

namespace Mlnky.Business.Services
{
    public interface IRedirectingService
    {
        string GetLongUrl(string shortCode);
       
    }
}
