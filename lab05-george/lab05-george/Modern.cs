using System;
using System.Collections.Generic;
using System.Text;

namespace lab05george
{
    abstract class Modern : RTS
    {
        //This is just passing through
        internal Modern(string title) : base(title) { }
        // implements Graphics and seals it so derived classes can't change this
        internal override sealed void Graphics() => Console.WriteLine("that was renderd in 3 dimensions.");
        // abstract class that has to be implemented in derived classes
        internal abstract void Scale();
    }
}
