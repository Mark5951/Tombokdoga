using System.Web;

namespace Tombokdoga
{
    internal class Program
    {
        static string[] huto = new string[10];

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
            return 10 - j;
        }

        static int KeresEtel(string etelNeve)
        {
            for (int i = 0; i < 10; i++)
            {
                if (huto[i] == etelNeve)
                {
                    return i;
                }
            }
            return 0;
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

            Console.WriteLine($"Ennyi üres hely maradt a hűtőben: {Takarit()}");
            Console.WriteLine($"A keresett etel indexe: {KeresEtel("steak")}");
            Console.WriteLine($"A magánhangzóval kezdődő szavak száma:");
            Maganhangzos();

        }
    }
}
