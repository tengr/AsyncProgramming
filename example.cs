using System;
using System.Threading;
using System.Threading.Tasks;
using CommandLine;
using System.Net;
namespace AsyncProgramming
{


    public class Program
    {
        public static int Main(string[] args)
        {

            MainAsync2(args).GetAwaiter().GetResult();
            return 0;
        }

        static async Task MainAsync1(string[] args)
        {
            Console.WriteLine("coffee is ready");

            Egg eggs = await FryEggs(2);
            Console.WriteLine("eggs are ready");
            Bacon bacon = await FryBacon(3);
            Console.WriteLine("bacon is ready");
            Toast toast = await ToastBread(2);
            Console.WriteLine("toast is ready");
        }

        static async Task MainAsync2(string[] args)
        {
            Console.WriteLine("coffee is ready");
            Task<Egg> eggTask = FryEggs(2);
            Task<Bacon> baconTask = FryBacon(3);
            Task<Toast> toastTask = ToastBread(2);

            Egg eggs = await eggTask;
            Console.WriteLine("eggs are ready");
            Bacon bacon = await baconTask;
            Console.WriteLine("bacon is ready");
            Toast toast = await toastTask;
            Console.WriteLine("toast is ready");
        }

        static async Task<Egg> FryEggs(int num)
        {
            await Task.Run(() =>
            {

                Console.WriteLine("started Frying Eggs");
                Thread.Sleep(10 * 1000);
            });
            Console.WriteLine("eggs done");
            return null;
        }

        static async Task<Bacon> FryBacon(int num)
        {
            await Task.Run(() =>
            {

                Console.WriteLine("started Frying Bacon");
                Thread.Sleep(10 * 1000);
            }
            );
            Console.WriteLine("bacon done");
            return null;
        }

        static async Task<Toast> ToastBread(int num)
        {
            await Task.Run(() =>
            {

                Console.WriteLine("started Toast");
                Thread.Sleep(10 * 1000);
            });
            Console.WriteLine("Toast done");
            return null;
        }

        class Bacon
        {

        }

        class Egg
        {
            
        }

        class Toast
        {

        }

        class Juice
        {

        }
    }
}
