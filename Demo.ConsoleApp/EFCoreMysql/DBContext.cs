using System;
using Demo.ConsoleApp.EFCoreMysql.Model;
using Microsoft.EntityFrameworkCore;

namespace Demo.ConsoleApp.EFCoreMysql
{
    public class DBContext : DbContext
    {
        public DBContext()
            :base()
        {

        }

        public DbSet<User> User { get; set; }

        //这里也可以
        string str = @"Data Source=52.226.70.155;Database=MysqlTest;User ID=root;Password=123456;pooling=true;CharSet=utf8;port=3306;sslmode=none";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseMySql(str);
    }
}
