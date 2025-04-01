using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace StudentService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        public void Data(Student student)
        {
            
                Console.WriteLine("Id: {0}, Name: {1}", student.Id, student.Name);
            
        }
    }
}
