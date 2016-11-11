using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades3
{
   public class Mascota:Animal
    {
        private string nombre;
        private eTipoDeMascota _tipoDeMascota;


        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public eTipoDeMascota TipoDeMascota
        {
            get { return this._tipoDeMascota; }
            set { this._tipoDeMascota = value; }
        }


        public Mascota(string nombre, eTipoDeMascota tipo, int edad)
            : base(edad)
        {
            this.nombre = nombre;
            this._tipoDeMascota = tipo;
        }

        public static int OrdenarPorEdad(Mascota mascotaUno, Mascota mascotaDos)
        {
            if (mascotaUno.Edad == mascotaDos.Edad)
            {
                return 0;
            }

            if (mascotaUno.Edad > mascotaDos.Edad)
            {
                return 1;
            }
            else
                return -1;
        }

        public static int OrdenarPorNombre(Mascota mascotaUno, Mascota mascotaDos)
        {
            return string.Compare(mascotaUno.nombre, mascotaDos.nombre);
        }

        public static int OrdenarPorTipo(Mascota mascotaUno, Mascota mascotaDos)
        {
            return string.Compare(mascotaUno.nombre.ToString(), mascotaDos.nombre.ToString());
        }

        public override string ToString()
        {
            return base.ToString() + " - Nombre: " + this.nombre + " - Tipo: " + this._tipoDeMascota.ToString();
        }
    }
}
