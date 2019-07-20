using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Domain.Interfaces;
using Users.Infrastructure;
using UsersApi.Models;

namespace UsersApi.Controllers
{
    [RoutePrefix("users")]
    public class UsersController : ApiController
    {
        private IUsersService _usersService;
        public UsersController(IUsersService usersService)
        {
            _usersService = usersService;
        }

        [Route(""), HttpGet]
        public List<UserModel> Get([FromUri] GetUsersRequest request)
        {
            throw new NotImplementedException();
        }

        [Route("{userId:int}"), HttpGet]
        public UserModel Get(int userId)
        {
            throw new NotImplementedException();
        }
    }
}
