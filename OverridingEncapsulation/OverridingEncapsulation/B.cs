﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverridingEncapsulation
{
    class B:A
    { 
         public B()
    {
        Console.WriteLine("Default constructor for B");
    }
    
       public override void printSomething()
        {
            Console.WriteLine("you are not that much old");
        } 
    }
}
