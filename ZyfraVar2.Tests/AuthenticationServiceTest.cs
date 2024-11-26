using ZyfraVar2.Repository;
using ZyfraVar2.Repository.Interfaces;
using ZyfraVar2.Services;
using ZyfraVar2.Services.Interfaces;
using ZyfraVar2.Tests;

namespace ZyfraVar2.Tests
{
    public class AuthenticationServiceTest
    {
        IAuthService authenticationService;


        [SetUp]
        public void Setup()
        {
            string filePath = "Test.csv";
            TestFile.CreateFile(filePath);
            UserRepository repository = new UserRepository(filePath);
            authenticationService = new AuthService(repository);
        }

        [Test]
        public void LogInByPassword()
        {
            if (authenticationService.LogIn("user0", "password0") == null)
                Assert.Fail();
            if (authenticationService.LogIn("user1", "password1") == null)
                Assert.Fail();

            if (authenticationService.LogIn("user0", "password1") != null)
                Assert.Fail();

            Assert.Pass();

        }

        
    }
}