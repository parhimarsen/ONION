using System.Collections.Generic;
using Domain.Model;
using Domain.Models;

namespace Domain.Interfaces
{
    public interface IUsersService
    {
        IList<DomainUser> SearchUsers(SerachingUsersFilter filter);

        DomainUser SearchUser(int userId);
    }
}
