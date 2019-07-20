using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Interfaces;
using Domain.Model;
using Domain.Models;
using Users.Infrastructure;

namespace Users.DomainServices.Services
{
    public class UsersService : IUsersService
    {
        private IUsersRepository _usersRepository;

        public UsersService(IUsersRepository usersRepository)
        {
            _usersRepository = usersRepository;
        }

        public IList<DomainUser> SearchUsers(SerachingUsersFilter filter)
        {
            if (filter == null)
            {
                throw new ArgumentNullException("FILTER");
            }

            throw new NotImplementedException();
        }

        public DomainUser SearchUser(int userId)
        {
            throw new NotImplementedException();
        }
    }
}
