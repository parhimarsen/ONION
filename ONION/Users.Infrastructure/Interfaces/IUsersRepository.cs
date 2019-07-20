using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Users.Infrastructure.Models;

namespace Users.Infrastructure
{
    public interface IUsersRepository
    {
        List<IfrastructureUser> GetUsers(int limit, int offset);

        IfrastructureUser GetUser(int userId);
    }
}
