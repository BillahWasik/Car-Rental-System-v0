using Microsoft.AspNetCore.Http;
using System.Security.Claims;

namespace Car_Rental_System.Service
{
    public class UserService : IUserService
    {
        private readonly IHttpContextAccessor httpContext;

        public UserService(IHttpContextAccessor _httpContext)
        {
            httpContext = _httpContext;
        }
        public string GetUserId()
        {
            var data = httpContext.HttpContext.User?.FindFirstValue(ClaimTypes.NameIdentifier);
            return data;
        }
        
        public bool IsAuthenticated() 
        {
           var data = httpContext.HttpContext.User.Identity.IsAuthenticated;
            return data;
        }
    }
}
