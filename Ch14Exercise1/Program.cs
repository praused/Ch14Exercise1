using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch14Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Giraffe myPetGiraffe = new Giraffe
            {
                NeckLength = 3.14,
                Name = "Gerald"
            };
            Console.WriteLine(myPetGiraffe);
            Console.ReadKey();
        }
    }
}
