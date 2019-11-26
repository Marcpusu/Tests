﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class ExtensionMethods
    {
        public static string ToDataBaseFormat(this DateTime dtDateTime)
        {
            return dtDateTime.ToString("yyyyMMdd HH:mm:ss");
        }
    }
}
