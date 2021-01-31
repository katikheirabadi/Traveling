using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using Travelling.Core.Dto;
using Travelling.Core.Models;

namespace Travelling.Core.Mapp
{
    public class MappConfig:Profile
    {
        public MappConfig()
        {
            CreateMap<SigninInputDTO, User>();
        }
    }
}
