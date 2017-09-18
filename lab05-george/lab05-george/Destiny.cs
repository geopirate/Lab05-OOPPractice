using System;
using System.Collections.Generic;
using System.Text;

namespace lab05george
{
    class Destiny : ScienceFiction
    {
        // this is the constructor from the base class
        // it interacts with the title method also passed from the base class
        internal Destiny(string title) : base(title) { }
        // overrides location as this doesn't occure on Earth
        internal override void Location() => Console.WriteLine("This occurs in spaaaaace!");
    }
}
