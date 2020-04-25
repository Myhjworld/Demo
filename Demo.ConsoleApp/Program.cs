using System;
using Demo.ConsoleApp.EFCoreMysql;
using Demo.ConsoleApp.EFCoreMysql.Model;

namespace Demo.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // var a = new TestClass();
            // a.ShowIn();

            MultiThreads.testM test=new MultiThreads.testM();
            test.showInfo();

            // User user = new User()
            // {
            //     Name = "hj2",
            //     Age = 13,
            //     Price = 14,
            //     CreateTime = DateTime.Now
            // };
            // a.Add(user);
        }
    }
}
