﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteEnvioFormulario.Extensions
{
    public static class ObjecExtension
    {
        public static bool IsNull(this object obj)
        {
            return obj == null;
        }
    }
}
