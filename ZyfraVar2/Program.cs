using Microsoft.Extensions.DependencyInjection;
using ZyfraVar2.Repository;
using ZyfraVar2.Services;

namespace ZyfraVar2
{
    internal class Program
    {
        static Random rand = new Random();
        
        static void CreateFile(string filePath)
        {

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("Логин;Пароль");

                for (int i = 0; i <= 10; i++)
                {
                    writer.WriteLine($"user{i};{rand.Next(0,10000)}");
                }
            }
        }
        static void Main(string[] args)
        {
            string filePath = "LoginData.csv";
            if (!File.Exists(filePath)) 
            {
                CreateFile(filePath);
            }

            UserRepository userRepository = new UserRepository(filePath);
            SessionRepository sessionRepository = new SessionRepository();
            AuthenticationService authenticationService = new AuthenticationService(userRepository);
            SessionService sessionService = new SessionService(sessionRepository);

            CommandHandler commandHandler = new CommandHandler(authenticationService, sessionService);

            Console.WriteLine("Достпные команды:");
            Console.WriteLine("login <логин> <пароль> - вход в систему по логину и паролю");
            Console.WriteLine("checkSession <идентефикатор сессии> - вход в систему по идентефикатору сессии");
            Console.WriteLine("delete <идентефикатор сессии> - удаление сессии по её идентефикатору");
            Console.WriteLine("exit - выход из программы");

            string? response;
            do
            {
                response = commandHandler.HandleCommand(Console.ReadLine()).Response;
                if (response != "exit") Console.WriteLine(response);
            } while (response != "exit");

        }
    }
}
