using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Async_and_parallel
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Thread thread = new Thread(helloWorld);
            thread.Start();
            thread.Join(); //se espera a que termine el thread

            Thread newThread = new Thread(helloParameters);
            newThread.Start(15);


            List<int> numeros = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            ParallelQuery<int> pruebaParallel = numeros.AsParallel().Select(n => n);
            pruebaParallel.ToList().ForEach(print);

            await Task.Run(() => Console.WriteLine("hello world from task"));


            await helloWorldAsync();


            Task<string> TareaString1 = Task.Run(() => "hello world from other task");
            Console.WriteLine(TareaString1.Result + " " + TareaString1.Id);
            Task<string> TareaString2 = Task.Run(() => "hello world from other task");
            Console.WriteLine(TareaString2.Result + " " + TareaString2.Id);
            Task<string> TareaString3 = Task.Run(() => "hello world from other task");
            Console.WriteLine(TareaString3.Result + " " + TareaString3.Id);

            Task.WaitAll(TareaString1, TareaString2, TareaString3);

            Task TareaString4 = Task.Run(() => Task.Delay(2000));
            Console.WriteLine(TareaString4 + " " + TareaString4.Id);
            Task TareaString5 = Task.Run(() => Task.Delay(2000));
            Console.WriteLine(TareaString5 + " " + TareaString5.Id);
            Task TareaString6 = Task.Run(() => Task.Delay(2000));
            Console.WriteLine(TareaString6 + " " + TareaString6.Id);

            await Task.WhenAll(TareaString4, TareaString5, TareaString6);

            helloWorldNormal();


            //Task.WaitAll blocks the current thread until everything has completed.
            //Task.WhenAll returns a task which represents the action of waiting until everything has completed.

            Console.WriteLine("WHEN ALL");
            Task[] taskArrayWhen =
            {
                Task.Factory.StartNew(() => WaitAndThrow(1, 1000)),
                Task.Factory.StartNew(() => WaitAndThrow(2, 2000)),
                Task.Factory.StartNew(() => WaitAndThrow(3, 3000))
            };

            await Task.WhenAll(taskArrayWhen);

            Console.WriteLine("WAIT ALL");
            Task[] taskArrayWait = 
            {
                Task.Factory.StartNew(() => WaitAndThrow(1, 1000)),
                Task.Factory.StartNew(() => WaitAndThrow(2, 2000)),
                Task.Factory.StartNew(() => WaitAndThrow(3, 3000))
            };

            Task.WaitAll(taskArrayWait);

            Console.ReadKey();
        }

        static void WaitAndThrow(int id, int MiliSeconds)
        {
            Console.WriteLine($"{DateTime.UtcNow}: Task {id} started");

            Thread.Sleep(MiliSeconds);
            
        }


        public static async Task helloWorldAsync()
        {
            Task<int> longRunnigTask = longRunnigOperationAsync();
            int result = await longRunnigTask;
            //use the result 
            Console.WriteLine("Result of LongRunningOperation() is " + result + " or " + longRunnigTask.Result);
        }

        private static async Task<int> longRunnigOperationAsync()
        {
            Console.WriteLine("LongRunningOperation() Started");
            await Task.Delay(2000); // 2 second delay
            Console.WriteLine("LongRunningOperation() Finished after 2 Seconds");
            return 1;
        }

        public static void helloWorldNormal()
        {
            int longRunnigTask = longRunnigOperation();
            int result = longRunnigTask;
            //use the result 
            Console.WriteLine("Result of LongRunningOperation() is " + result + " or " + longRunnigTask);
        }

        private static int longRunnigOperation()
        {
            Console.WriteLine("LongRunningOperation() NORMAL Started");
            Task.Delay(2000); // 2 second delay
            Console.WriteLine("LongRunningOperation() Finished after 2 Seconds NORMAL");
            return 1;
        }

        static void print(int s)
        {
            Console.WriteLine(s.ToString());
        }

        static void helloWorld()
        {
            Console.WriteLine("hello world from thread");
        }

        public static void helloParameters(object data)
        {
            Console.WriteLine("hello world from other Thread with Data='{0}'", data);
        }
    }
}
