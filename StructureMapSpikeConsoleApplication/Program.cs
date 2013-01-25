using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StructureMap;

namespace StructureMapSpikeConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = Ioc.Initialize();

            var ninja = container.GetInstance<INinja>();


            container.AssertConfigurationIsValid();
            
            
            
            
            Console.Out.WriteLine("Hello World!");
            Console.Out.WriteLine(container.WhatDoIHave());
            Console.Read();
        }
    }
}
