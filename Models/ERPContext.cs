using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineErpApi.Models
{
    public class ERPContext : IdentityDbContext
    {
        public ERPContext()
        {

        }

        public ERPContext(DbContextOptions<ERPContext> options)
           : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
        }


    }
}
