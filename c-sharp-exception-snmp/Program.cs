using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using Microsoft.Practices.Unity.Utility;

using Lextm.SharpSnmpLib;
using Lextm.SharpSnmpLib.Pipeline;
using Lextm.SharpSnmpLib.Security;

namespace c_sharp_exception_snmp
{
    class Program
    {
        internal static IUnityContainer Container { get; private set; }
        static void Main(string[] args)
        {
            Container = new UnityContainer().LoadConfiguration("snmptrapd");
            //HandlerMapping hMap = new HandlerMapping();
            //Lextm.SharpSnmpLib.Pipeline.MessageHandlerFactory container = new Lextm.SharpSnmpLib.Pipeline.MessageHandlerFactory();
            var users = Program.Container.Resolve<UserRegistry>();
            var trapv2 = Container.Resolve<TrapV2MessageHandler>("TrapV2Handler");
            /*
            trapv2.MessageReceived += WatcherTrapV2Received;
            using (var engine = Container.Resolve<SnmpEngine>())
            {
                engine.Listener.AddBinding(new IPEndPoint(IPAddress.Any, 162));
                engine.Start();
            }
            ExceptionWrap e = new ExceptionWrap();
            e.send();
            */
        }
    }

}
