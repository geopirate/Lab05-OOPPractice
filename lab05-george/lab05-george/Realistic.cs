using System;
using System.Collections.Generic;
using System.Text;

namespace lab05george
{
    class Realistic : Shooter
    {
        //This is just passing through
        internal Realistic(string title) : base(title){ }
        // virtual class can be used as is or implemented in child classes
        internal virtual void TimeFrame() => Console.Write("This occurs in a modern time frame.");
        // implements Ammo and seals it so derived classes can't change this
        internal override sealed void Ammo() => Console.WriteLine(
            "that uses ammo like bullets.");
    }
}
