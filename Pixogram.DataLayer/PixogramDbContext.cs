using Microsoft.EntityFrameworkCore;
using Pixogram.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pixogram.DataLayer
{
    public class PixogramDbContext :DbContext
    {
        public PixogramDbContext(DbContextOptions<PixogramDbContext> options) 
            : base(options)
        {
        }

        public DbSet<Content> Content { get; set; }
        public DbSet<User> User { get; set; }
    }
}
