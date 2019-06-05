using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashRoyaleClanMonitorWF.Utils
{
    public static class EnumConverter 
    {
        public static T StrToEnum<T>(this string Str )
        {
            return  (T)Enum.Parse(typeof(T), Str);
        }
    }
}
