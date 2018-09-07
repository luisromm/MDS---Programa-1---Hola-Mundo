using MDS___Programa_1___Hola_Mundo.Classes;
using MDS___Programa_1___Hola_Mundo.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDS___Programa_1___Hola_Mundo
{
    class Program
    {
        static void Main(string[] args)
        {
            //snippets
            Console.Write("Hola Mundo");

            //invocación anonima
            new Person();

            //referencia de un objeto
            Person myObject = new Person();

            //instancia de una clase
            Person personInstance = new Person("Luis");

            //uso de Model-View-Controller MVC
            new EmployeeView();
            
            Console.Read();
        }
    }
}
