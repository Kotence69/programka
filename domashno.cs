using System;

namespace domashno_iliq
{
    class Program
    {
        static void Main(string[] args)
        {
            //okolna povyrhnina na prav krygov cilindyr
           
            Console.Write("h = ");
            double h = double.Parse(Console.ReadLine());
            Console.Write("r = ");
            double r = double.Parse(Console.ReadLine());
            Console.Write("V = ");
            double V = 3.14 * r * r * h;
            Console.WriteLine(V);
            Console.ReadLine();

            //pylna povyrhnina na prav krygov cilindyr
           
            
            Console.Write("r = ");
            double r1 = double.Parse(Console.ReadLine());
            Console.Write("h = ");
            double h1 = double.Parse(Console.ReadLine());
            Console.Write("S = ");
            double S = 2 * 3.14 * r * h;
            Console.WriteLine(S);
            Console.ReadLine();

            // namirane na S1
            
            Console.Write("r = ");
            double r2 = double.Parse(Console.ReadLine());
            Console.Write("h = ");
            double h2 = double.Parse(Console.ReadLine());
            Console.Write("S1 = ");
            double S1 = 2 * 3.14 * r * (h + r);
            Console.WriteLine(S1);
            Console.ReadLine();
        
        
        
        
        }

    }
}

