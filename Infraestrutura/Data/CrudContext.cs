using Infraestrutura.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestrutura.Data
{
    public class CrudContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }

        public CrudContext(DbContextOptions options) : base(options)
        {

        }
    }
}
