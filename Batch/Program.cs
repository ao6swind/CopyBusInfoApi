using System;
using Services;

namespace Batch
{
    class Program
    {
        static void Main(string[] args)
        {
            RouteService routeService = new RouteService();
            StopService stopService = new StopService();
            Console.WriteLine("Copy open date from New Taipei city open data platform start!");
            routeService.Backup();
            stopService.Backup();
            Console.WriteLine("Copy open date from New Taipei city open data platform finsh!");
            Console.ReadLine();
        }
    }
}
