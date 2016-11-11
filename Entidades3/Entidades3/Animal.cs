using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades3
{
   public class Animal
    {
        private int edad;

        public int Edad
        {
            get { return this.edad; }
            set { this.edad = value; }
        }

        public Animal(int edad)
        {
            this.edad = edad;
        }

        public override string ToString()
        {
            return "La edad es: " + this.edad;
        }

    }
}
