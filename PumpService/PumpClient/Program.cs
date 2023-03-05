using PumpClient.PumpServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace PumpClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InstanceContext instanceContext = new InstanceContext(new CallbackHandler());
            PumpServiceClient client = new PumpServiceClient(instanceContext);

            client.UpdateAndCompileScript("D:\\Users\\repository\\C_Sharp\\ProtocolsTest\\PumpService\\PumpService\\Scripts\\Sample.script");
            
            client.RunScript();

            Console.ReadKey(true);
            client.Close();
        }
    }
}
