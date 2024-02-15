using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_gradus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gradus: ");
            int gradus = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Minute: ");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Second: ");
            int sec = Convert.ToInt32(Console.ReadLine());

            Angle angle = new Angle(gradus, min, sec);

            double rad = angle.ToRadians();
            Console.WriteLine(rad);
            Console.ReadKey();
        }
    }
}
