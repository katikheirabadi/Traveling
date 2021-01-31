using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Travelling.Core.Dto;

namespace Travelling.Core.Service
{
    interface ISigninuserRepository
    {
        public  Task<IActionResult> Create(SigninInputDTO signin);
    }
}
