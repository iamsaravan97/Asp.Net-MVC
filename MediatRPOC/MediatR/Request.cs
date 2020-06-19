using MediatR;
using MediatRPOC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatRPOC.MediatR
{
    public class Request : IRequest<int>
    {
        public  int  Count { get {  return 5; } }
    }


    public class Request2 : IRequest<string>
    {
        public  string Count { get { return "Five"; } }
    }

    public class UserQuery : IRequest<User>
    {
        public int Id { get; set; }
    }



}
