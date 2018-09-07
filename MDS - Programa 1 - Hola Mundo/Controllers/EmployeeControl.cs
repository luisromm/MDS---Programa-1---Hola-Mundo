using MDS___Programa_1___Hola_Mundo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDS___Programa_1___Hola_Mundo.Controllers
{
    class EmployeeControl
    {
        public EmployeeControl()
        {
            Employee employee = new Employee();
            employee.NameEmployee = "Roberto";
            employee.Age = 37;

            Console.WriteLine("Name: {0}\n Age: {1}",
                employee.NameEmployee, employee.Age);
        }
    }
}
