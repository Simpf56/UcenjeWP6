using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace MojProjekat
{
    internal class VK3
    {
        public static void VjezbaKuci()
        {
            //Console.WriteLine("VK3");


            int redovi = 5; 
            int stupci = 5; 

            int[,] tablica = new int[stupci, redovi];

            int vrijednost = 0;

            int red = redovi - 1;
            int stup = stupci - 1;

            for (stup = stupci - 1; stup >= 0; stup--)
            {
                tablica[red, stup] = vrijednost++;
            }
                
            for(red = redovi -1;red >= 0; red--)
            {
                    tablica[red, 0] = vrijednost++;
            }               
            
            for (stup = 1; stup < stupci; stup++)
            {
                tablica[0,stup] = vrijednost++;
            }

            for(red = 1;red < redovi-1; red++)
            {
                tablica[red, stupci -1] = vrijednost++;
            }
            
            for (stup = stupci - 2; stup >= 1; stup--)
            {
                tablica[red-1, stup] = vrijednost++;
            }
             
            for (red = redovi - 2; red >= 1; red--)
            {
                tablica[red, stup + 1] = vrijednost++;
            }
            
            for (stup = stupci/stupci;stup <= 2; stup ++) 
            {
                tablica[red + 1, stup + 1] = vrijednost++;
            }

            //for (red = redovi/2;red >= redovi / 2; red--)
            //{
            //    tablica[]
            //}

            


            for (int i = 0; i < tablica.GetLength(0); i++)
            {
                for (int j = 0; j < tablica.GetLength(1); j++)
                {
                    Console.Write(tablica[i, j] + "\t");
                }
                Console.WriteLine();
            }

        }
            



        
                
















        
    }
}
