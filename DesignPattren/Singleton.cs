using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    internal class BusinessClass
    {
        private BusinessClass()
        {

        }

        private static BusinessClass? _instance;

        public static BusinessClass GetSingletonObject()
        {
           
             //return _instance == null ? new BusinessClass() : _instance;
            return _instance ?? new BusinessClass();

        }


        public void PrintHelloOnScreen()
        {
            Console.WriteLine("Hello");
        }
    }
}
