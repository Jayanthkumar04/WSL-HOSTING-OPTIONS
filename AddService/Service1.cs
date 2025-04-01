using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AddService
{
    //[ServiceBehavior(IncludeExceptionDetailInFaults = true)]

    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        public int Addition(int a, int b)
        {
            return a + b;
        }

        public double Addition(double a,double b)
        {
            return a + b;
        }

        public double Division(int a,int b)
        {
            try
            {
                return a / b;
            }
            catch (Exception ex)
            {
                DivFault fault = new DivFault();
                fault.Message = "The second parameter cannot be zero";
                fault.OperationMessage = ex.Message;
                throw new FaultException<DivFault>(fault);
                    
            }
        }
    }
}
