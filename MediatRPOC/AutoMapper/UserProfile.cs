using MediatRPOC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace MediatRPOC.AutoMapper
{
    public class UserProfile : Profile
    {
       public UserProfile()
        {
            CreateMap<User, UserViewModel>()
                .ForMember(dest => dest.FName, opt => opt.MapFrom(src => src.Forename))
                .ForMember(dest => dest.SName, opt => opt.MapFrom(src => src.Surname));


        }

    }
}
