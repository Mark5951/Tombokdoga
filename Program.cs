namespace Tombokdoga
{
    internal class Program
    {
        static string[] huto = new string[10];

        static int Takarit()
        {
            int db = 0;

            for (int i = 0; i < 10; i++)
            {
               if (huto[i] != "")
               {
                    huto[db] = huto[i];
                    db++;
               }

            }

            for (int i = db; i < 10; i++)
            {
                huto[i] = "";
            }
            return 10 - db;
        }

        
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                huto[i] = "";
            }
            huto[0] = "alma";
            huto[2] = "tej";
            huto[4] = "eper";
            huto[6] = "steak";

        }
    }
}
