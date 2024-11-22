using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace VTEX.API.Middleware
{
    public class AuthenticationMiddleware
    {
        private readonly RequestDelegate _next;

        public AuthenticationMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            // Lógica para verificar o token de autenticação
            await _next(context);
        }
    }
}
