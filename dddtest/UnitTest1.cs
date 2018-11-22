using DDD.Vcs.Domain;
using Moq;
using NUnit.Framework;

namespace Tests
{
    public class UnitTest1
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            const string login = "smalaca";
            const string codeBaseName = "ddd-project";
            Developer developer = new Developer(login);
            var codeBaseRepository = new Mock<CodeBaseRepository>();
            var service = new CodeBaseService(codeBaseRepository.Object, aRepositoryWithDeveloper(login, developer));

            service.CreateNew(codeBaseName, login);

            CodeBase codeBase = new CodeBase(codeBaseName, developer);
            codeBaseRepository.Verify(repository => repository.Add(It.Is<CodeBase>(baseR => baseR.sameAs(codeBase))), Times.Once);

        }

        private static DeveloperRepository aRepositoryWithDeveloper(string login, Developer developer)
        {
            var developerRepository = new Mock<DeveloperRepository>();
            developerRepository.Setup(repository => repository.Find(login)).Returns(developer);
            DeveloperRepository develRepo = developerRepository.Object;
            return develRepo;
        }
    }
}