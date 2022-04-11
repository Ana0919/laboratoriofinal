using Entities;

namespace Contracts
{
    public interface IApplicationUser
    {
        ApplicationUser FindByUser(string UserName);
        bool CheckUserAndPassword(ApplicationUser applicationUser);
        bool AddUser(ApplicationUser applicationUser);
    }
}
