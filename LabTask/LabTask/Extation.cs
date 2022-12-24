using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask
{
    internal static class Extation
    {
        public static string GetInfo(this User user1)
        {
            return $"{user1.Name}{user1.Surname}";


        }
    }
}
