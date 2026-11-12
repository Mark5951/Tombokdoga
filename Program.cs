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

        static int[] LeghosszabbNovekvo()
        {
            int max = 1;
            int db = 1;
            int kezdet = 0;

            for (int i = 1; i < 10; i++)
            {
                if (szamok[i] > szamok[i - 1])
                {
                    db++;
                }
                else
                {
                    db = 1;
                }

                if ( db > max)
                {
                    max = db;
                    kezdet = i - db + 1;
                }
            }

            int[] uj = new int[max];

            for (int i = 0; i < max; i++)
            {
                uj[i] = szamok[kezdet + i];
            }

            return uj;

        }

        static void AtlagAlattiDuplazas()
        {
            double osszeg = 0;

            for (int i = 0; i < 10; i++)
            {
                osszeg += szamok[i];
            }

            double atlag = osszeg / 10;

            for (int i = 0; i < 10; i++)
            {
                if (szamok[i] < atlag)
                {
                    szamok[i] = szamok[i] * 2;
                }
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

            FeltoltEgyediekkel(1, 30);

            Console.WriteLine("Eredeti tömb:");
            for (int i = 0; i < szamok.Length; i++)
            {
                Console.WriteLine(szamok[i]);
            }

            Console.WriteLine();

            int[] novekvo = LeghosszabbNovekvo();

            Console.WriteLine("Leghosszabb növekvő részsorozat:");
            for (int i = 0; i < novekvo.Length; i++)
            {
                Console.WriteLine(novekvo[i]);
            }

            Console.WriteLine();
            AtlagAlattiDuplazas();

            Console.WriteLine("Módosított tömb:");
            for (int i = 0; i < szamok.Length; i++)
            {
                Console.WriteLine(szamok[i]);
            }


        }
    }
}
