using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatRPOC.Models
{
    public class UserViewModel
    {
        public int UserId { get; set; }

        public string Username { get; set; }
        public string FName { get; set; }
        public string SName { get; set; }

        public string Email { get; set; }


    }
}
