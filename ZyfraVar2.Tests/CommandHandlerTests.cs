using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZyfraVar2.Repository;
using ZyfraVar2.Services.Interfaces;
using ZyfraVar2.Services;

namespace ZyfraVar2.Tests
{
    public class CommandHandlerTests
    {
        //IAuthService authenticationService;
        //ISessionService sessionService;
        //CommandHandler commandHandler;
        //string sessionId;


        //[SetUp]
        //public void Setup()
        //{
        //    string filePath = "Test.csv";
        //    TestFile.CreateFile(filePath);
        //    UserRepository userRepository = new UserRepository(filePath);
        //    SessionRepository sessionRepository = new SessionRepository();
        //    authenticationService = new AuthService(userRepository);
        //    sessionService = new SessionService(sessionRepository);
        //    commandHandler = new CommandHandler(authenticationService, sessionService);
        //}

        //[Test]
        //public void CreateSession()
        //{
        //    sessionId = sessionService.CreateSession("user0");
        //    if (sessionId.Length == 0) Assert.Fail();

        //    Assert.Pass();

        //}

        //[Test]
        //public void DeleteCommand()
        //{
        //    sessionId = sessionService.CreateSession("user0");

        //    if (!commandHandler.HandleCommand($"delete {sessionId}").Result) Assert.Fail();

        //    if (commandHandler.HandleCommand($"delete {sessionId}").Result) Assert.Fail();

        //    Assert.Pass();
        //}

        //public void LoginByPasswordCommand()
        //{
        //    if (!commandHandler.HandleCommand("login user0 password0").Result) Assert.Fail();

        //    if (commandHandler.HandleCommand("login user1 password0").Result) Assert.Fail();

        //    Assert.Pass();
        //}

        //public void LoginBySessionCommand()
        //{

        //    if (!commandHandler.HandleCommand("loginSession ###").Result) Assert.Fail();

        //    sessionId = sessionService.CreateSession("user0");

        //    if (commandHandler.HandleCommand($"loginSession {sessionId}").Result) Assert.Fail();

        //    Assert.Pass();
        //}

        //[Test]
        //public void ExitCommand()
        //{
        //    CommandHandlerResponse response = commandHandler.HandleCommand("exit");
        //    if (response.Equals(new CommandHandlerResponse("exit", true))) Assert.Fail(response.Response);

        //    Assert.Pass();
        //}

        //[Test]
        //public void UnknownCommand()
        //{
        //    CommandHandlerResponse response = commandHandler.HandleCommand("ddasdsadd");
        //    if (response.Equals(new CommandHandlerResponse("Команда не распознана", false))) Assert.Fail(response.Response);

        //    Assert.Pass();
        //}
    }
}
