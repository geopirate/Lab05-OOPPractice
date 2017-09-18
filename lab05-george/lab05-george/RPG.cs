using System;
using System.Collections.Generic;
using System.Text;

namespace lab05george
{
    // level 1 of inheritance, the genre
    // this is derived from Game
    internal abstract class RPG : Game
    {
        //This is just passing through
        internal RPG(string title) : base(title){}
        // implements Genre and seals it so derived classes can't change this
        internal override sealed void Genre() => Console.Write("  This is a role playing game.");
        // abstract class that has to be implemented in derived classes
    }
}
