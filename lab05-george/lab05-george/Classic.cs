using System;

namespace lab05george
{
    abstract class Classic : RTS
    {
        //This is just passing through
        internal Classic(string title) : base(title){}
        // implements Graphics and seals it so derived classes can't change this
        internal override sealed void Graphics() => Console.WriteLine("that used 2d sprites.");
        // abstract class that has to be implemented in derived classes
        internal abstract void Races();
    }
}


