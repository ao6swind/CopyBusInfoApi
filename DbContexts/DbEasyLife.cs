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

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            string connection = "server=localhost;database=DbEasyLife;user=AppEasyLife;password=IloveTaiwan@2019";
            builder.UseMySQL(connection);
        }
    }
}
