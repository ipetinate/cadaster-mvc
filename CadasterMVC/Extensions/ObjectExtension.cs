using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadasterMVC.Extensions
{
    public static class ObjectExtension
    {
        public static bool IsNull(this object obj)
        {
            return obj == null;
        }
    }
}
