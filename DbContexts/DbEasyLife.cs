using System;
using Microsoft.EntityFrameworkCore;
using MySql.Data.EntityFrameworkCore.Extensions;
using MySql.Data.EntityFrameworkCore;
using Models;

namespace DbContexts
{
    public class DbEasyLife : DbContext
    {
        public DbEasyLife() : base()
        {

        }

        public virtual DbSet<Route> Routes {get; set;}
        public virtual DbSet<Stop> Stops {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseMySQL(DbConnectionString.DbEasyLife);
        }
    }
}
