using System;
using System.Collections.Generic;
using System.Text;

namespace Pixogram.Models
{
    public class Feedback

    { 
        public virtual int Id { get; set; }
        public virtual int UserId { get; set; }
        public virtual int SenderUserId { get; set; }
        public virtual string Comment { get; set; }
        public virtual bool Like { get; set; }
    }
}
