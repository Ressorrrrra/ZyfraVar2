using Microsoft.AspNetCore.Mvc;
using ZyfraVar2.Services.Interfaces;
using ZyfraVar2.Services;
using ZyfraVar2;
using Microsoft.AspNetCore.Authentication;

namespace ZyfraVar2.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SessionController : ControllerBase
    {
        private readonly ISessionService _sessionService;
        private readonly IAuthService _authService;

        public SessionController(ISessionService sessionService, IAuthService authService)
        {
            _sessionService = sessionService;
            _authService = authService;
        }
        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetSession (Guid id) 
        {
            var response = _sessionService.CheckSession(id);

            if (response)
            {
                return Ok("Вы уже вошли в систему");
            }
            return Unauthorized("Данный id сессии не был найден");
        }

        [HttpPost]
        public async Task<IActionResult> CreateSession([FromBody] LogInRequest request)
        {
            var response = _authService.LogIn(request.Login, request.Password);
            if (response != null)
            {
                return Ok(_sessionService.CreateSession(response.Login));
            }
            return NotFound("Неправильно введён логин или пароль");
        }

        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> DeleteSession(Guid id)
        {
            var response = _sessionService.DeleteSession(id);

            if (response)
            {
                return Ok("Сессия удалена");
            }
            return NotFound("Сессия не была найдена");
        }



    }
}
