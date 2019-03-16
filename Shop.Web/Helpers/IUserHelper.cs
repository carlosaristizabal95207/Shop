

namespace Shop.Web.Helpers
{
    using Data.Entities;
    using Microsoft.AspNetCore.Identity;


    using System.Threading.Tasks;

    internal interface IUserHelper
    {
        Task<User> GetUserByEmailAsync(string Email);

        Task<IdentityResult> AddUserAsync(User user, string password);

    }
}
