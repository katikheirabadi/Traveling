﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Travelling.Core.Models
{
    public class Rate
    {
        public int id { get; set; }
        public int RateInt { get; set; }
        public int userid { get; set; }
        public User user { get; set; }
        public int Tp_id { get; set; }
        public Turist_PLace Tp_ { get; set; }
        public DateTime RecordDate { get; set; }
    }
}
