﻿using AutoMapper;
using CommonInfrastructure.DTO;
using HostWeb.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HostWeb.Mapping
{
    public class ScriptProfile : Profile
    {
        public ScriptProfile()
        {
            CreateMap<ScriptDTO, Script>()
                .ForMember(dest => dest.Id, options => options.Ignore())
                .ForMember(dest => dest.InnerId, opt => opt.MapFrom(src => src.Id));
            CreateMap<Script, ScriptDTO>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.InnerId));
        }
    }
}
