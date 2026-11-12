using System.Web;

namespace Tombokdoga
{
    internal class Program
    {
        static string[] huto = new string[10];

        static int[] szamok = new int[10];

        static Random r = new Random();

        static int Takarit()
        {
            int j = 0;

            for (int i = 0; i < 10; i++)
            {
               if (huto[i] != "")
               {
                    huto[j] = huto[i];
                    j++;
               }

            }

            for (int i = j; i < 10; i++)
            {
                huto[i] = "";
            }
            return j;
        }

        static int KeresEtel(string etelNeve)
        {
            int i = 0;

            while (i < 10 && huto[i] != etelNeve)
            {
                i++;
            }
            if ( i== 10)
            {
                return 0;
            }
            else
            {
                return i;
            }

        }

        static void Maganhangzos()
        {
            for (int i = 0; i < 10; i++)
            {
                if (huto[i] != "")
                {
                    char betu = huto[i][0];
                    string maganhanzok = "aáeéiíoóöőuúüű";
                    
                    if (maganhanzok.Contains(betu))
                    {
                        Console.WriteLine(huto[i]);
                    }
                }
            }
        }

        static void FeltoltEgyediekkel(int min, int max)
        {
            for (int i = 0; i < 10; i++)
            {
                int szam = r.Next(min, max + 1);
                bool letezik = true;

                while (letezik)
                {
                    letezik = false;

                    for (int j = 0; j < i; j++)
                    {
                        if (szamok[j] == szam)
                        {
                            letezik = true;
                        }
                    }

                    if (letezik)
                    {
                        szam = r.Next(min, max + 1);
                    }
                }

                szamok[i] = szam;
            }
        }




        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                huto[i] = "";
            }
            huto[0] = "alma";
            huto[1] = "";
            huto[2] = "tej";
            huto[3] = "";
            huto[4] = "eper";
            huto[5] = "";
            huto[6] = "steak";
            huto[7] = "";
            huto[8] = "zöldség";
            huto[9] = "ananász";

            Console.WriteLine($"Az élelmiszerek száma a hűtőben: {Takarit()}");
            Console.WriteLine($"A keresett étel indexe: {KeresEtel("steak")}");
            Console.WriteLine($"A magánhangzóval kezdődő szavak száma:");
            Maganhangzos();

        }
    }
}
