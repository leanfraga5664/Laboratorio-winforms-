using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModeloParcialBinding
{
    public partial class Telefono : Form
    {
        private BindingSource _bs;
        public Telefono()
        {
            InitializeComponent();

        }

        public Telefono(BindingSource bs)
        {
            InitializeComponent();
            _bs = bs;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Telefono_Load(object sender, EventArgs e)
        {
            this.textBox1.DataBindings.Add(new Binding("Text", _bs, "nombre"));
            this.textBox2.DataBindings.Add(new Binding("Text", _bs, "direccion"));
            this.textBox3.DataBindings.Add(new Binding("Text", _bs, "telefono"));
            this.textBox4.DataBindings.Add(new Binding("Text", _bs, "observaciones"));
        }
    }
}
