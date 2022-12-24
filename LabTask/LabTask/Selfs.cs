using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask
{
    internal static class Selfs
    {
        public static double Menfeet { get; set; }
        public static double Zerer { get; set; }
        
        public static void Salar()
        {
            int result = 11;
            if (Menfeet< result)
            {
                Console.WriteLine("menfeet");
            }
            else if (Zerer > result)
            {
                Console.WriteLine("zerer");
            }
            else
            {
                Console.WriteLine("hecne");
            }
            
        }
    }
}
