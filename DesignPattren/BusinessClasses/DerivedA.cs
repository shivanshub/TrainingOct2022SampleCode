using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BusinessClasses
{
    internal class DerivedA : BaseClass

    {
        public override void WriteOnScreen()
        {
           Console.WriteLine("I am Derived Call A");
        }
    }
}
