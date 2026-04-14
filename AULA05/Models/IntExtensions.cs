using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AULA05.Models
{
    public static class IntExtensions
    {
        public static bool EhPar(this int number)
        {
            return number % 2 == 0;
        }
    }
}