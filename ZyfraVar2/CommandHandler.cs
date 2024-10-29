using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZyfraVar2.Services.Interfaces;

namespace ZyfraVar2
{
    public class CommandHandler
    {
        IAuthenticationService authenticationService;
        ISessionService sessionService;

        public CommandHandler(IAuthenticationService authenticationService, ISessionService sessionService)
        {
            this.authenticationService = authenticationService;
            this.sessionService = sessionService;
        }
        public CommandHandlerResponse HandleCommand(string command) 
        {
            string[] parts = command.Split(' ');
            switch (parts[0])
            {
                case "delete":
                    string sessionId = parts[1];
                    if (sessionService.DeleteSession(sessionId))
                        return new CommandHandlerResponse("Сессия была успешно удалена", true);
                    else
                        return new CommandHandlerResponse("Сессия не была найдена", false);
                case "loginSession":
                    sessionId = parts[1];
                    if (authenticationService.LogIn(sessionId))
                        return new CommandHandlerResponse("Вы уже вошли в систему", true);
                    else
                        return new CommandHandlerResponse("Данной сессии не существует, войдите по логину и паролю", false);
                case "login":
                    string login = parts[1];
                    string password = parts[2];
                    UserData user = authenticationService.LogIn(login, password);
                    if (user != null)
                    {
                        sessionId = sessionService.CreateSession(user.Login);
                        return new CommandHandlerResponse($"Вы успешно вошли. Идентефикатор сессии: {sessionId}", true);
                    }
                    else
                    {
                        return new CommandHandlerResponse("Неправильно введён логин или пароль", false);
                    }
                case "exit":
                    return new CommandHandlerResponse("exit", true);
                default:
                    return new CommandHandlerResponse("Команда не распознана", false);

            };
        }
    }
}
