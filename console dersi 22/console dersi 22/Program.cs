using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_dersi_22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] dizi = new int[5,5];
            int[,] matris= new int[3,3];
            int i, k;
            Console.WriteLine("lütfen matrisinizi oluşturun:");
            for(i=0;i<5;i++)
            {
                for(k=0;k<5;k++)
                {
                    dizi[i,k]=Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("lütfen matrisinizi oluşturun:");
            for (i = 0; i < 5; i++)
            {
                for (k = 0; k < 5; k++)
                {
                    matris[i, k] = Convert.ToInt32(Console.ReadLine());
                }
            }


        }
    }
}
