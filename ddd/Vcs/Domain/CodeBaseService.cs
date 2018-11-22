using System;

namespace DDD.Vcs.Domain
{
    public class CodeBaseService
    {
        private CodeBaseRepository codeBaseRepository;
        private DeveloperRepository developerRepository;

        public CodeBaseService(CodeBaseRepository codeBaseRepository, DeveloperRepository developerRepository)
        {
            this.codeBaseRepository = codeBaseRepository;
            this.developerRepository = developerRepository;
        }

        public void CreateNew(string repositoryName, string login)
        {
            codeBaseRepository.Add(new CodeBase(repositoryName, developerRepository.Find(login)));
        }
    }
}
