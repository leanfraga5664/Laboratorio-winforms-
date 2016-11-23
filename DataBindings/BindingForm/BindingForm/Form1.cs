using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BindingForm
{
    public partial class Form1 : Form
    {
        private Persona _miPersona;

        public Persona MiPersona
        {
            get { return _miPersona; }
            set { _miPersona = value; }
        }
        
        private BindingSource _bs;

        public Form1()
        {
            InitializeComponent();        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
           
        }
        public Form1(Persona unaPersona)
            :this()
        {
            this._miPersona = unaPersona;

            this._bs = new BindingSource();

            this._bs.DataSource = this._miPersona;

            this.Enlazar();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this._miPersona = new Persona(234, "Juan", "Gomez", 23);

          
        }


        private void Enlazar()
        {
            this.txtId.DataBindings.Add("Text", this._bs, "Id");
            this.txtNombre.DataBindings.Add("Text", this._bs, "Nombre");
            this.txtApellido.DataBindings.Add("Text", this._bs, "Apellido");
            this.txtEdad.DataBindings.Add("Text", this._bs, "Edad");

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if(this._miPersona != null)
            MessageBox.Show("Id: " + this._miPersona.Id.ToString() + " Nombre: " + this._miPersona.Nombre + " " + this._miPersona.Apellido + "   Edad: " + this._miPersona.Edad.ToString());

        }
    }
}
