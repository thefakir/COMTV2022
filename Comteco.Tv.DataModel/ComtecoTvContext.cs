using Microsoft.EntityFrameworkCore;
using Npgsql.EntityFrameworkCore.PostgreSQL;
using System;
using System.Collections.Generic;
using System.Text;

namespace Comteco.Tv.DataModel
{
    public class ComtecoTvContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql(@"Host=localhost; Port=5432; Database=ComtecoTv; Username=postgres; Password=sa");
    }
}
