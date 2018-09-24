using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feladat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> szamok = new List<int>();
            Console.WriteLine("Kérem adja meg azt a számot, hogy mennyi darab számot irassak ki:");
            int bekertszamok;
            while(!(int.TryParse(Console.ReadLine(), out bekertszamok)))
            {
                Console.WriteLine("Számot adj meg.");
            }
            int max = 0;
            for (int i = 1; i <= bekertszamok; i++){
                Console.WriteLine("Kérem írja be a(z)" + i + "." + " számot.");
                szamok.Add(int.Parse(Console.ReadLine()));
                
               
            }
            foreach(var s in szamok)
            {
                if(s > max)
                {
                    max = s;
                }
            }
            Console.WriteLine("A legnagyobb szám: " + max);
            int min = max;
            foreach (var s in szamok)
            {
                if (s < min)
                {
                    min = s;
                }
            }
            Console.WriteLine("A legkisebb szám: " + min);

            

            Console.ReadLine();
        }
    }
}
