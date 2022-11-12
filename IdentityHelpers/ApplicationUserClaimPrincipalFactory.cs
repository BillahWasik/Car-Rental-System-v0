using Car_Rental_System.IdentityModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Car_Rental_System.IdentityHelpers
{
    public class ApplicationUserClaimPrincipalFactory : UserClaimsPrincipalFactory<CustomizeUser , IdentityRole> 
    {
        public ApplicationUserClaimPrincipalFactory(UserManager<CustomizeUser> userManager , RoleManager<IdentityRole> roleManager,
            IOptions<IdentityOptions> options ) : base(userManager,roleManager,options)
        {

        }

        protected override async Task<ClaimsIdentity> GenerateClaimsAsync(CustomizeUser user)
        {
            var data = await base.GenerateClaimsAsync(user);
            data.AddClaim(new Claim("FirstName", user.FirstName ?? ""));
            data.AddClaim(new Claim("LastName", user.LastName ?? ""));

            return data;
        }
    }
}
