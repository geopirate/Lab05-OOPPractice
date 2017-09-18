using System;
using System.Collections.Generic;
using System.Text;

namespace lab05george
{
    // level 1 of inheritance, the genre
    // this is derived from Game
    abstract class Shooter : Game
    {
        //This is just passing through
        internal Shooter(string title) : base(title){}
        // implements Genre and seals it so derived classes can't change this
        internal override sealed void Genre() => Console.Write(
            "  This is a first person shooter, ");
        // abstract class that has to be implemented in derived classes
        internal abstract void Ammo();
    }
}
