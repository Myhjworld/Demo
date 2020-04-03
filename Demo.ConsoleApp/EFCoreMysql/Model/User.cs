using System;
namespace Demo.ConsoleApp.EFCoreMysql.Model
{
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public decimal Price { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
