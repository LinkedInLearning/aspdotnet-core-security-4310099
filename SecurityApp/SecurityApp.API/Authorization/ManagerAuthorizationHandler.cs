using Microsoft.AspNetCore.Authorization;
using SecurityApp.API.Models;

namespace SecurityApp.API.Authorization
{
    public class ManagerAuthorizationHandler : AuthorizationHandler<SameManagerRequirement, User>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, SameManagerRequirement requirement, User resource)
        {
            if(context.User.HasClaim("Id", resource.HiringManagerId.ToString()))
            {
                context.Succeed(requirement);
            }

            return Task.CompletedTask;
        }
    }
}
