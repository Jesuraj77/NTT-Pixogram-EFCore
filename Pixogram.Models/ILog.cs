using System;
using System.Collections.Generic;
using System.Text;

namespace Pixogram.Models
{
   public class ILog
    {
        public Content content { get; set; } 
        public Feedback feedback { get; set; }
        public Follow follow { get; set; }
    }
}
