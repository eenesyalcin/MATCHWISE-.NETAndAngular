using matchwiseServer.Application.Features.Auth.Login;
using matchwiseServer.Domain.Entities;

namespace matchwiseServer.Application.Services
{
    public interface IJwtProvider
    {
        Task<LoginCommandResponse> CreateToken(AppUser user);
    }
}
