using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Vcs.Domain
{
    public interface DeveloperRepository
    {
        Developer Find(string login);
    }
}
