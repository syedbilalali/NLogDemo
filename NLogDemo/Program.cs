using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NLog;

namespace NLogDemo
{
    class Program
    {
        private static readonly Logger _logger = LogManager.GetCurrentClassLogger();
        static void Main(string[] args)
        {
            Console.WriteLine(" ----- Starting Application -------" + AppDomain.CurrentDomain.BaseDirectory);
            //Log the way 
            _logger.Error(" OH ! Error is Here.....");
            Console.WriteLine("---- Going to End Application ------->");
            Console.ReadKey();
        }
    }
}
