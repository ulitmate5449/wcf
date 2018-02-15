using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAcessLayer;
namespace BusinessLogicLayer
{
    public class Employee
    {
        public int empo { get; set; }
        public string ename { get; set; }
        public int mgr { get; set; }

        public static List<Employee> GetEmployee()
        {
            List<Employee> employees = null;
            employees = (from emp in Class1.GetEmployee()
                         select new BusinessLogicLayer.Employee
                         {
                             empo = emp.empno,
                             ename = emp.ename,
                             mgr = emp.mgr

                         }).ToList();
            return employees;
        }

    }
}
