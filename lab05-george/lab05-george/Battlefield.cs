using System;
using System.Collections.Generic;
using System.Text;

namespace lab05george
{
    class Battlefield : Realistic
    {
        // this is the constructor from the base class
        // it interacts with the title method also passed from the base class
        internal Battlefield(string title) : base(title) { }
        // no need to override TimeFrame, inherited from Realistic as a virtual class as this uses present tense
        //internal override void TimeFrame() => Console.Write("This occurs in a modern time frame.");
    }
}
