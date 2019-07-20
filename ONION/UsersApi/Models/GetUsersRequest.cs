using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UsersApi.Models
{
    public class GetUsersRequest
    {
        public int? Limit { get; set; } = 5;
        public int? Offser { get; set; }
    }
}