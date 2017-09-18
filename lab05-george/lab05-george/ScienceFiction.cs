using System;
using System.Collections.Generic;
using System.Text;

namespace lab05george
{
    class ScienceFiction : Shooter
    {
        //This is just passing through
        internal ScienceFiction(string title) : base(title){ }
        // virtual class can be used as is or implemented in child classes
        internal virtual void Location() => Console.Write("This occurs on an alternative future Earth.");
        // implements Ammo and seals it so derived classes can't change this
        internal override sealed void Ammo() => Console.WriteLine(
            "that uses ammo like lasers.");
    }
}
