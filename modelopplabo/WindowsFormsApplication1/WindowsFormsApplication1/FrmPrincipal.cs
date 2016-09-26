using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;



public enum eTipoDeOrdenamiento
{
    PorEdad, PorNombre, PorTipo
}


namespace WindowsFormsApplication1
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();

            foreach (string item in Enum.GetNames(typeof(eTipoDeOrdenamiento)))
            {
                toolStripComboBox1.Items.Add(item);
            }
            this.toolStripComboBox1.SelectedIndex = 1;
            this._listaMascotas = new List<Mascota>();
        }

        private List<Mascota> _listaMascotas; 
        private Comparison<Mascota> comparador;
        private ActualizarLista actualizador;
        FrmMascota frmMasc;


        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            
            
            
            
        }

        

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            eTipoDeOrdenamiento tipo = (eTipoDeOrdenamiento)toolStripComboBox1.SelectedItem;

            switch (tipo)
            {
                case eTipoDeOrdenamiento.PorEdad:
                    {
                        this.comparador += Mascota.OrdenarPorEdad;
                        break;
                    }

                case eTipoDeOrdenamiento.PorNombre:
                    {
                        this.comparador += Mascota.OrdenarPorNombre;
                        break;
                    }

                case eTipoDeOrdenamiento.PorTipo:
                    {
                        this.comparador += Mascota.OrdenarPorTipo;
                        break;
                    }
            }


            this._listaMascotas.Sort(comparador);
            this.RefrescarLista();

        }

        private void RefrescarLista()
        {
            this.listBox1.Items.Clear();

            foreach (Mascota unaMascota in this._listaMascotas)
            {
                this.listBox1.Items.Add(unaMascota);
            }
        }

        

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.btnBaja.Click += ManejadorCentral;
            this.btnModificar.Click += ManejadorCentral;
            this.listBox1.SelectedIndexChanged -= new EventHandler(listBox1_SelectedIndexChanged);

        }
        

        private void Baja()
        {
            if (this._listaMascotas != null)
            {
                foreach (Mascota item in this._listaMascotas)
                {
                    if (this.listBox1.SelectedItem == item)
                    {
                        this._listaMascotas.Remove(item);
                        this.RefrescarLista();
                    }
                }
            }

            if (actualizador != null)
            {
                actualizador(this._listaMascotas);
            }
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            this.btnBaja.Click -= new EventHandler(ManejadorCentral);
            this.btnModificar.Click -= new EventHandler(ManejadorCentral);
            this.listBox1.SelectedIndexChanged += new EventHandler(listBox1_SelectedIndexChanged);

           
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            this.btnBaja.Click -= new EventHandler(ManejadorCentral);
            this.btnModificar.Click -= new EventHandler(ManejadorCentral);
            this.listBox1.SelectedIndexChanged += new EventHandler(listBox1_SelectedIndexChanged);
        }


        private void ManejadorCentral(object sender, EventArgs e)
        {
            
            if ((((ToolStripMenuItem)sender).Name == btnBaja.Name) && (listBox1.SelectedIndex >= 0))
            {
                
                //frmasc = new FrmMascota(this._listaMascotas[listBox1.SelectedIndex]);
                if (frmMasc.ShowDialog(this) == DialogResult.OK)

                {
                    
                    this.Baja();
                    this.RefrescarLista();

                }
            }

            else if ((((ToolStripMenuItem)sender).Name == btnModificar.Name) && (listBox1.SelectedIndex >= 0))
            {

                if (frmMasc.ShowDialog(this) == DialogResult.OK)
                {
                    frmMasc = new FrmMascota(this._listaMascotas[listBox1.SelectedIndex]);
                    this._listaMascotas[listBox1.SelectedIndex] = frmMasc.mascota;
                    this.RefrescarLista();
                }

                if (actualizador != null)
                {
                    actualizador(this._listaMascotas);
                }
            }

            

        }
        

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Desea cerrar la aplicación?", "Salir?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            frmMasc = new FrmMascota();
            frmMasc.ShowDialog(this);

            if (frmMasc.DialogResult == DialogResult.OK)
            {
                
                    this._listaMascotas.Add(frmMasc.mascota);
                    this.RefrescarLista();
              
                
                if (actualizador != null)
                {
                    actualizador(this._listaMascotas);
                }

            }
        }

        private void actualizarListadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMostrar mostr = new FrmMostrar();
            actualizador = new ActualizarLista(mostr.ActualizarListados);
        }
    }
}
