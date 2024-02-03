using _4._4_StereoMultifunzione.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._4_StereoMultifunzione
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //array di massimo 20 per ogni supporto

            AudioCassetta[] audioCassetta = new AudioCassetta[20];
            Vinile[] vinile = new Vinile[20];
            CD[] cd = new CD[20];

            //creazione oggetti

            AudioCassetta audioCassetta1 = new AudioCassetta("C46: della durata di 23 minuti per lato");
            audioCassetta[0] = audioCassetta1;

            AudioCassetta audioCassetta2 = new AudioCassetta("C60: della durata di 30 minuti per lato.");
            audioCassetta[1] = audioCassetta2;

            AudioCassetta audioCassetta3 = new AudioCassetta("C90: della durata di 45 minuti per lato.");
            audioCassetta[2] = audioCassetta3;

            AudioCassetta audioCassetta4 = new AudioCassetta("C120: della durata di 60 minuti per lato.");
            audioCassetta[3] = audioCassetta4;


            Vinile vinile1 = new Vinile("15'-20'");
            vinile[0] = vinile1;

            Vinile vinile2 = new Vinile("15'");
            vinile[1] = vinile2;

            Vinile vinile3 = new Vinile("15'-20'");
            vinile[2] = vinile3;

            Vinile vinile4 = new Vinile("60'");
            vinile[3] = vinile4;

            Vinile vinile5 = new Vinile("3'");
            vinile[4] = vinile5;

            Vinile vinile6 = new Vinile("5'-7'");
            vinile[5] = vinile6;

            Vinile vinile7 = new Vinile("3'");
            vinile[6] = vinile7;

            Vinile vinile8 = new Vinile("3'");
            vinile[7] = vinile8;


            CD cd1 = new CD("74–99 min");
            cd[0] = cd1;

            CD cd2 = new CD("21–24 min");
            cd[1] = cd2;

            CD cd3 = new CD("6 min");
            cd[2] = cd3;

            //diagramma delle classi mancante perchè presente solo a scuola
        }
    }
}
