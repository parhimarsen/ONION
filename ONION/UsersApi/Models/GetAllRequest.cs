using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UsersApi.Models
{
    public class GetAllRequest
    {
        public int? Limit { get; set; }

        public int? Offset { get; set; }
    }
}