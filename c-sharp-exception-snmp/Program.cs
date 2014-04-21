using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using Microsoft.Practices.Unity.Utility;

namespace c_sharp_exception_snmp
{
    class Program
    {
        internal static IUnityContainer Container { get; private set; }
        static void Main(string[] args)
        {
            Container = new UnityContainer().LoadConfiguration("snmptrapd");
        }
    }

}
