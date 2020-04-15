using System;
using System.Linq;
using Demo.ConsoleApp.EFCoreMysql.Model;

namespace Demo.ConsoleApp.EFCoreMysql
{
    public class TestClass
    {
        public readonly DBContext _dB = new DBContext();
        public TestClass()
        {
        }

        public void Show()
        {
            var user = _dB.Set<User>().ToList();

            foreach (var item in user)
            {
                Console.WriteLine($"姓名：{item.Name}，ID:{item.ID}");
            }
        }

        public void ShowIn()
        {
            var user = _dB.Set<User>().Where(u=>new int[]{1,3}.Contains(u.ID));

            foreach (var item in user)
            {
                Console.WriteLine($"姓名：{item.Name}，ID:{item.ID}");
            }
        }

        
    }
}
