using Microsoft.EntityFrameworkCore;
using MoK_PT1_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoK_PT1_API
{
    public class PT1Context : DbContext
    {
        public PT1Context(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Login> LoginInfo { get; set; }
    }
}
