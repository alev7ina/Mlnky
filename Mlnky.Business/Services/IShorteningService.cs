using System;
using System.Collections.Generic;
using System.Text;

namespace Mlnky.Business.Services
{
    public interface IShorteningService
    {
        string Shorten(string longUrl, string baseUrl);
    }
}
