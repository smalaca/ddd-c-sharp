using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Vcs.Domain
{
    public class CodeBase
    {
        private string codeBaseName;
        private Developer developer;

        public CodeBase(string codeBaseName, Developer developer)
        {
            this.codeBaseName = codeBaseName;
            this.developer = developer;
        }

        public bool sameAs(CodeBase codeBase)
        {
            return codeBaseName == codeBase.codeBaseName && 
                developer == codeBase.developer;
        }
    }
}
