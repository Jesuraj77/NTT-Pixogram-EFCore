using System;
using System.Collections.Generic;
using System.Text;

namespace Pixogram.Models
{
    public class Follow

    {
        public virtual int Id { get; set; }
        public virtual int UserId { get; set; }

        public virtual int FollowUserId { get; set; }
      
    }
}
