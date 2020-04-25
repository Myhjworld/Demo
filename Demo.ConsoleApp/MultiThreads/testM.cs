using System;
using System.Diagnostics;
using System.Threading;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Demo.ConsoleApp.MultiThreads
{
    public class testM
    {
        
        testObejcts ob=new testObejcts();
        
        public testM()
        {
            ob.name="hj";
        }

        public void showInfo()
        {
            Stopwatch stopWatch=new Stopwatch();
            stopWatch.Start();
            for (int i = 0; i < 10; i++)
            {
                int k=i;
                Task.Run(()=>{
                    System.Console.WriteLine($"Thread={Thread.CurrentThread.ManagedThreadId} 姓名={ob.name}");
                    if(k==3)
                    {
                        ob.name="hj2";
                    }
                });
            }
            stopWatch.Stop();
            System.Console.WriteLine($"执行时间:{stopWatch.ElapsedMilliseconds}");
            stopWatch.Reset();
            stopWatch.Start();
            TaskFactory task=new TaskFactory();
            task.StartNew(()=>{
                
            })
            stopWatch.Stop();
            System.Console.WriteLine($"执行时间:{stopWatch.ElapsedMilliseconds}");
            
        }

    }
}