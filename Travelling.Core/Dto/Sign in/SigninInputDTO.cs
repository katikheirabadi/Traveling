﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Travelling.Core.Dto
{
    public class SigninInputDTO
    {
        public string FullName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Re_Password { get; set; }
        public string Phone_Number { get; set; }
    }
}
