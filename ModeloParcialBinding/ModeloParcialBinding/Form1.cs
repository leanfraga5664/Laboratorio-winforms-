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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'telefonosDS1.telefonos' table. You can move, or remove it, as needed.
            this.telefonosTableAdapter.Fill(this.telefonosDS1.telefonos);

        }

        private void bajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Telefono frmTel = new Telefono(this.telefonosBindingSource);

            if (frmTel.ShowDialog() == DialogResult.OK)
            {
                this.telefonosBindingSource.RemoveCurrent();

            }
            else
            {

            }
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.telefonosBindingSource.EndEdit();
            this.telefonosTableAdapter.Update(this.telefonosDS1.telefonos);
            MessageBox.Show("Se ha salvado");
        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.telefonosBindingSource.AddNew();
            Telefono frmTel = new Telefono(this.telefonosBindingSource);

            if (frmTel.ShowDialog() == DialogResult.OK)
            {
              

            }
            else
            {

            }
        }

        private void modificacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Telefono frmTel = new Telefono(this.telefonosBindingSource);

            if (frmTel.ShowDialog() == DialogResult.OK)
            {
                //this.telefonosBindingSource.RemoveCurrent();

            }
            else
            {

            }
        }
    }
}
