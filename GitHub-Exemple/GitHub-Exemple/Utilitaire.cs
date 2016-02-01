using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHub_Exemple
{
    static class Utilitaire
    {
        static Random randomGen = new Random();

        static int GenRan(int min, int max)
        {
            return randomGen.Next(min, max + 1);
        }

        static void WriteTable(int[] table)
        {
            Console.WriteLine("Ecrire la table");
	}

        
        static int[] GenTable(int lenght)
        {
            int[] Table = new int[lenght];
            
            return Table;
        }
    }
}
