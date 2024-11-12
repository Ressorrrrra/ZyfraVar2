
using Microsoft.AspNetCore.Mvc;
using ZyfraVar2.Services.Interfaces;

namespace ZyfraVar2.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.CreateDependencies("LoginData.csv");

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.MapGet("api/sessions/{id:guid}", (Guid id, ISessionService sessionService) =>
            {
                var response = sessionService.CheckSession(id.ToString());

                if (response)
                {
                    return Results.Ok("Вы уже вошли в систему");
                }
                return Results.NotFound("Данный id сессии не был найден");
            });


            app.MapPost("api/users", ([FromBody()] UserData userData, IAuthenticationService authenticationService, ISessionService sessionService) =>
                {
                    var response = authenticationService.LogIn(userData.Login, userData.Password);
                    if (response != null) 
                    {
                        return Results.Ok(sessionService.CreateSession(response.Login));
                    }
                    return Results.NotFound("Неправильно введён логин или пароль");
                });

            app.MapDelete("api/sessions/{id:guid}", (Guid id, ISessionService sessionService) =>
            {
                var response = sessionService.DeleteSession(id.ToString());

                if (response)
                {
                    return Results.Ok("Сессия удалена");
                }
                return Results.NotFound("Сессия не была найдена");
            });


            app.Run();
        }
    }
}
