using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindingForm
{
    public class Persona
    {
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _nombre;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        private string _apellido;

        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }

        private int _edad;

        public int Edad
        {
            get { return _edad; }
            set { _edad = value; }
        }

        public Persona()
        {

        }

        public Persona(int id, string nombre, string apellido, int edad)
            :this()
        {
            this._id = id;
            this._nombre = nombre;
            this._apellido = apellido;
            this._edad = edad;

        }
        
        
        
        
    }
}
