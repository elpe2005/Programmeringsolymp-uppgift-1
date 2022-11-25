using System;
namespace uppgift1
{
    class Program
    {
        static void Main(string[]args)
        {
            Random slump = new Random();
            int Torstid = slump.Next(1,101);
            int morstid = slump.Next(1,101);

            Console.WriteLine("Här är Tors tid:" + Torstid);
            Console.WriteLine("Här är mors tid:" + morstid);

            int morsmorötter = slump.Next(1,41);
            int torsmorötter = slump.Next(1,41);

            while (morsmorötter + torsmorötter < 41)
            {
                Console.WriteLine("mors morötter:"+morsmorötter);
                Console.WriteLine("tors morötter:"+torsmorötter);  
                Console.WriteLine("Dem ville inte äta 40 idag");
                break;
            }
        }
    }
}