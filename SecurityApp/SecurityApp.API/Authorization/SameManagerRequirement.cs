using Microsoft.AspNetCore.Authorization;

namespace SecurityApp.API.Authorization
{
    public class SameManagerRequirement : IAuthorizationRequirement
    {
    }
}
