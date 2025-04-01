﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AddService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract(Name ="AdditionService")]
    public interface IService1
    {
        [OperationContract(Name ="AddServiceInt")]
        int Addition(int a, int b);

        [OperationContract(Name ="AddServiceDouble")]
        double Addition(double a, double b);

        [OperationContract]
        double Division(int a,int b);

            
    }

   
}
