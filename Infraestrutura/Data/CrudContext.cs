using Infraestrutura.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestrutura.Data
{
    public class CrudContext : DbContext
    {
        public CrudContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Movie> Movies { get; set; }
    }
}
