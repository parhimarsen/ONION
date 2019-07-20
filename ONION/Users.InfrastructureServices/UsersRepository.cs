using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Users.Infrastructure;
using Users.Infrastructure.Models;

namespace Users.InfrastructureServices
{
    public class UsersRepository : IUsersRepository
    {
        public List<IfrastructureUser> data = new List<IfrastructureUser>()
        {
            new IfrastructureUser() { Id = 1, Name = "Денис", Role = "Admin", Sex = "М", Age = 20},
            new IfrastructureUser() { Id = 2, Name = "Александр", Role = "Admin", Sex = "М", Age = 21},
            new IfrastructureUser() { Id = 3, Name = "Арсений", Role = "Admin", Sex = "М", Age = 22},
            new IfrastructureUser() { Id = 4, Name = "Виктория", Role = "Admin", Sex = "Ж", Age = 25},
            new IfrastructureUser() { Id = 5, Name = "Андрей", Role = "Admin", Sex = "М", Age = 20},
            new IfrastructureUser() { Id = 6, Name = "Дмитрий", Role = "Admin", Sex = "М", Age = 40},
            new IfrastructureUser() { Id = 7, Name = "Евгений", Role = "Admin", Sex = "М", Age = 33},
            new IfrastructureUser() { Id = 8, Name = "Юрий", Role = "Admin", Sex = "М", Age = 21}
        };

        public List<IfrastructureUser> GetUsers(int limit, int offset)
        {
            IEnumerable<IfrastructureUser> users;

            if (offset < data.Count)
            {
                users = data.Skip(offset).Take(limit);
            }
            else
            {
                users = Enumerable.Empty<IfrastructureUser>();
            }

            return users.ToList();
        }

        public IfrastructureUser GetUser(int userId)
        {
            throw new NotImplementedException();
        }
    }
}
