using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MojProjekat
{
    internal class VK06
    {
        public static void VjezbaKuci()
        {
            int redovi = 10;
            int stupci = 10;

            int[,] tablica = new int[redovi, stupci];

            int vrijednost = 0;
            int max_vrijednost = redovi * stupci;

            int prviRed = 0;
            int zadnjiRed = redovi - 1;
            int prviStup = 0;
            int zadnjiStup = stupci - 1;

            while (vrijednost < max_vrijednost)
            {
                // 1. Dolje desno → lijevo
                for (int stup = zadnjiStup; stup >= prviStup && vrijednost < max_vrijednost; stup--)
                {
                    tablica[zadnjiRed, stup] = vrijednost++;
                }
                zadnjiRed--; // Smanjujemo donju granicu

                // 2. Dolje lijevo → gore
                for (int red = zadnjiRed; red >= prviRed && vrijednost < max_vrijednost; red--)
                {
                    tablica[red, prviStup] = vrijednost++;
                }
                prviStup++; // Povećavamo lijevu granicu

                // 3. Gore lijevo → desno
                for (int stup = prviStup; stup <= zadnjiStup && vrijednost < max_vrijednost; stup++)
                {
                    tablica[prviRed, stup] = vrijednost++;
                }
                prviRed++; // Povećavamo gornju granicu

                // 4. Gore desno → dolje
                for (int red = prviRed; red <= zadnjiRed && vrijednost < max_vrijednost; red++)
                {
                    tablica[red, zadnjiStup] = vrijednost++;
                }
                zadnjiStup--; // Smanjujemo desnu granicu
            }

            // Ispis tablice
            for (int i = 0; i < redovi; i++)
            {
                for (int j = 0; j < stupci; j++)
                {
                    Console.Write(tablica[i, j].ToString("D2") + "\t");
                }
                Console.WriteLine();
            }
        }
    }

}