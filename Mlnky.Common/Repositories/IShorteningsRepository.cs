using Mlnky.Common.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mlnky.Common.Repositories
{
    public interface IShorteningsRepository
    {
        void Save(Shortening shortening);

        Shortening FindOne(long shortCode);
    }
}
