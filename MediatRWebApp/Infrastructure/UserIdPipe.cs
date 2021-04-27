using System.Linq;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.VisualBasic;

namespace MediatRWebApp.Infrastructure
{
    public class UserIdPipe<TIn, TOut> : IPipelineBehavior<TIn, TOut>
    {
        private HttpContext _httpContext;
        
        public UserIdPipe(HttpContextAccessor accessor)
        {
            _httpContext = accessor.HttpContext;
        }
        
        public Task<TOut> Handle(
            TIn request, 
            CancellationToken cancellationToken, 
            RequestHandlerDelegate<TOut> next)
        {
            var userID = _httpContext.User.Claims
                .FirstOrDefault(x => x.Type.Equals(ClaimTypes.NameIdentifier))
                ?.Value;
            
            throw new System.NotImplementedException();
        }
    }
}