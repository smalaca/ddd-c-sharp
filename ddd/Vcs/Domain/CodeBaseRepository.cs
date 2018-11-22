using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Vcs.Domain
{
    public interface CodeBaseRepository
    {
        void Add(CodeBase codeBase);
    }
}
