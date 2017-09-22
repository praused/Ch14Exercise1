using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch14Exercise1
{
    public class Giraffe
    {
        public double NeckLength { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return "Giraffe named " + Name + ", neck length " + NeckLength + " meters."; 
        }

        public Giraffe(double neckLength, string name)
        {
            NeckLength = neckLength;
            Name = name;
        }

        //To use an object initializer with a this class, I need to explicitly define a default (parameterless) constructor.
        //Since there is a nondefault constructor, a default constructor will not be generated automatically by the compiler.
        //Instead of defining a default constructor, I could have removed the nondefault constructor.
        public Giraffe()
        {
        }
    }
}
