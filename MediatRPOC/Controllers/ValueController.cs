using System;
using System.Collections.Generic;
using System.Linq;
using MediatR;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MediatRPOC.MediatR;
using MediatRPOC.Models;
using AutoMapper;
using System.ComponentModel.DataAnnotations;

namespace MediatRPOC.wwwroot
{
    public class ValueController : Controller
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public ValueController(IMediator mediator, IMapper mapper)
        {

            _mediator = mediator;
            _mapper = mapper;
        }

       
        public ActionResult<dynamic> GetInt()
        {
            return _mediator.Send(new Request()).Result;
        }

        public ActionResult<dynamic> GetString()
        {
            return _mediator.Send(new Request2()).Result;
        }


        [HttpGet]
        
        [Route("users/{userId}")]
        public async Task<IActionResult> UserDetails(int userId)
        {
            User user = await _mediator.Send(new UserQuery{ Id = userId });

            UserViewModel model = _mapper.Map <UserViewModel>(user);

            model.Email = "saransaravana1997@gmail.com";

            return View(model);
        }

    }
}
