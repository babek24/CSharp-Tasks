using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Square.Extention
{
    internal static class Helper
    {
        public static double toSquare(this double number) 
        { 
        double Square=number*number;
            return Square;
        }
        
    }
}
