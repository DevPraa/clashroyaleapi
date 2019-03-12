using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClashRoyaleClanMonitorWF.Utils
{
    public static class ControlHelper
    {
        public static void InvokeEx(this Control control, Action action)
        {
            if (control.InvokeRequired) control.Invoke(action); else action();
        }

        //public static void InvokeEx<T>(this Control control, Action<T> action,T arg)
        //{
        //    if (control.InvokeRequired) control.Invoke(action); else action(arg);
        //}
        public static TResult InvokeEx<TResult>(this Control control, Func<TResult> action)
        {
            if (control.InvokeRequired) return (TResult)control.Invoke(action); else return action();
        }
    }
}
