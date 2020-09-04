using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlazorWithApi.Entities;

namespace BlazorWithApi.Data
{
    public class BlazorWithApiContext : DbContext
    {
        public BlazorWithApiContext (DbContextOptions<BlazorWithApiContext> options)
            : base(options)
        {
        }

        public DbSet<BlazorWithApi.Entities.Customer> Customer { get; set; }
    }
}
