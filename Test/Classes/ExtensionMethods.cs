using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
