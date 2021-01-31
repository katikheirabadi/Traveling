using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Travelling.Core.Dto;
using Travelling.Core.Models;
using Travelling.Core.Service;

namespace Travelling.Core.ModelsServiceRepository
{
    public class SigninRepository //: ISigninuserRepository
    {
        private readonly IMapper mapper;
        public SigninRepository(IMapper mapper)
        {
            this.mapper = mapper;
        }
        //public async Task<IActionResult> Create(SigninInputDTO signin)
        //{
        //    var user = mapper.Map<User>(signin);
        //    if (user.Password != user.Re_Password)
        //    {
        //        return 
        //    }
            
        //}
    }
}
