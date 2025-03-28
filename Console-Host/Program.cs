using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AddService;
using System.ServiceModel;
using System.ServiceModel.Description; 
namespace Console_Host
{
    public class Program
    {
        static void Main(string[] args)
        {
            Uri baseAddress = new Uri("http://localhost:6001");

            ServiceHost sh = new ServiceHost(typeof(Service1), baseAddress);

            ServiceEndpoint se = sh.AddServiceEndpoint(typeof(IService1), new BasicHttpBinding(), baseAddress);

            ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
            smb.HttpGetEnabled = true;
            sh.Description.Behaviors.Add(smb);

            sh.Open();
            Console.WriteLine("Service is ready.......");

            Console.ReadLine();

            sh.Close();


        }
    }
}
