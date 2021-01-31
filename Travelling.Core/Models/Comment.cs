using System;
using System.Collections.Generic;
using System.Text;

namespace Travelling.Core.Models
{
    public class Comment
    {
        public int id { get; set; }
        public string Text { get; set; }
        public DateTime RecordDate { get; set; }
        public int userid { get; set; }
        public User user { get; set; }
        public int TP_id { get; set; }
        public Turist_PLace TP_ { get; set; }
    }
}
