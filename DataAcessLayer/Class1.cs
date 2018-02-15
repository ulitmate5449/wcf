using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DataAcessLayer.ServiceReference1;

namespace DataAcessLayer
{
    
    public class Class1
    {
       
        public static List<tblEmployee> GetEmployee()
        {
            
            Service1Client a = new Service1Client();

            return a.getemployee().ToList();
        }
    }
}
