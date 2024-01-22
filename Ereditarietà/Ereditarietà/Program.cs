using Ereditarietà.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ereditarietà
{
    internal class Program
    {
        static void Main(string[] args)
        {
            cane pluto = new cane(true, "Cane Pluto"); //nuovo oggetto della sottoclasse cane

            Console.WriteLine(pluto.EmettiVerso()); //non viene stampato il verso generico della classe di base ma "bau bau bau" della sottoclasse cane
            pluto.Dormire();

            Console.ReadLine();

        }
    }
}