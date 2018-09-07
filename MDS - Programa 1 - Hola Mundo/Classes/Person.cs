using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDS___Programa_1___Hola_Mundo.Classes
{
    class Person
    {
        //attributes or fields
        private string name;
        private char genre;
        public short age;
        protected double size;
        // tabla de rangos de los tipos de datos en C#

        //methods
        //metodo constructor
        public Person()
        {
            //encargado de alojar memoria suficiente
            //para la creación del objeto
            this.name = string.Empty;
            this.genre = '\0';
            this.age = 0;
            this.size = 0.0;
        }

        public Person(string name)
        {
            this.name = name;
        }

        //metodos de accesibilidad o de mutación
        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }

        public int Function()
        {
            return 0;
        }

        private void Process()
        {

        }
    }
}
