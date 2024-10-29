using ZyfraVar2.Repository;
using ZyfraVar2.Repository.Interfaces;
using ZyfraVar2.Services;
using ZyfraVar2.Services.Interfaces;
using ZyfraVar2.Tests;

namespace ZyfraVar2.Tests
{
    public class AuthenticationServiceTest
    {
        IAuthenticationService authenticationService;
        ISessionService sessionService;


        [SetUp]
        public void Setup()
        {
            string filePath = "Test.csv";
            TestFile.CreateFile(filePath);
            UserRepository repository = new UserRepository(filePath);
            authenticationService = new AuthenticationService(repository);
            sessionService = new SessionService(repository);
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



        [Test]
        public void LogInBySession()
        {
            UserData user = authenticationService.LogIn("user0", "password0");

            string sessionId = sessionService.CreateSession(user.Login);

            if (!authenticationService.LogIn(sessionId)) Assert.Fail();

            if (authenticationService.LogIn("ww")) Assert.Fail();

            Assert.Pass();

        }

        
    }
}