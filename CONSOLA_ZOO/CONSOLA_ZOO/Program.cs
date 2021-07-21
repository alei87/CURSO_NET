using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONSOLA_ZOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Mamifero mam = new Mamifero("perro", "koki", 15, 12);
            Ave ave1 = new Ave ("paloma", "kiki", 2, 14, "verde", 12);
            Insecto ins = new Insecto("Araña", "pepita", 1, 12, false);

            mam.ClaseDeAnimalEres();
            ave1.ClaseDeAnimalEres();
            ins.ClaseDeAnimalEres();
            Console.ReadLine();

            
        }
    }
}
