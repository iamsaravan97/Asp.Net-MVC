using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatRPOC.MediatR;
using System.Threading;
using Microsoft.AspNetCore.Server.HttpSys;

using MediatRPOC.Models;


namespace MediatRPOC.MediatR
{
    public class Handler : IRequestHandler<Request, int>
    {
        public async Task<int> Handle(Request req, CancellationToken ct)
        {
            var i = req.Count;
            return i;
        }
    }

    public class Handler2 : IRequestHandler<Request2, string>
    {
        public async Task<string> Handle(Request2 req, CancellationToken ct)
        {
            return req.Count;


        }
    }

    public class UserQueryHandlerAsync : IRequestHandler<UserQuery, User>
    {
        public async Task<User> Handle(UserQuery message,CancellationToken ct)
        {
            

            User user = new User();
          
            user.UserId = message.Id;
            user.Username = "saravana123";
            user.Forename = "Saravana";
            user.Surname = "DOXC";
            
            return user;
     
        }
    }


}
    


