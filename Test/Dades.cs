using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Test
{
    public class Dades
    {
        public static CultureInfo Culture = new CultureInfo("es-ES", false);
        public static CultureInfo DBCulture = new CultureInfo("es-ES", false);
        //public static string DateFormat = "dd" + Culture.DateTimeFormat.DateSeparator + "MM" + Culture.DateTimeFormat.DateSeparator + "yyyy";
        public static NumberStyles NStyle = NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowLeadingSign;
    }
}
