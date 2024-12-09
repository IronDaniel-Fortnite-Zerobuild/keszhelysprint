using System.Net;

namespace keszhelysprint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Versenyzo> Versenyzok = new();
            foreach (var sor in File.ReadAllLines("eredmenyek.txt"))
            {
                Versenyzok.Add(new Versenyzo(sor));
            }
            Console.WriteLine($"A versenyt {Versenyzok.Count} versenyzök fejezték be!");

            int elit_junitor = 0;
            foreach (var v in Versenyzok)
            {
                if (v.Kategoria == "elit_junior")
                {
                    elit_junior++;
                }
                Console.WriteLine($"versenyzök száma az \"elit_junior\"kategoriában:{elit_junior} fö");


            }

      
        }
        

    }

}
