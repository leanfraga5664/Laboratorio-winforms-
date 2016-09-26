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

namespace WindowsFormsApplication1
{
    public partial class FrmMascota : FrmAnimal
    {
        public FrmMascota()
        {
            InitializeComponent();

            foreach (string tipo in Enum.GetNames(typeof(eTipoDeMascota)))
            {
                cmbBxTipo.Items.Add(tipo);
                
            }
            cmbBxTipo.SelectedIndex = 1;
        }

        private Mascota mascota1;

        

        public FrmMascota(Mascota mascota1)
        {
           this.mascota1 = mascota1;

        }

        public Mascota mascota
        {
            get { return this.mascota1; }
            
        }

        
        

        protected override void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                base.btnAceptar_Click(sender, e);
                this.mascota1 = new Mascota(txtNombre.Text, (eTipoDeMascota)Enum.Parse(typeof(eTipoDeMascota),
                    cmbBxTipo.SelectedItem.ToString()), int.Parse(txtEdad.Text));
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido una excepcion en Aceptar", ex.Message);
            }
        }

        private void FrmMascota_Load(object sender, EventArgs e)
        {
            if (mascota != null)
            {
                this.txtNombre.Text = this.mascota.Nombre;
                this.txtEdad.Text = this.mascota1.Edad.ToString();
                this.cmbBxTipo.SelectedItem = mascota1.TipoDeMascota;
            }
        }
    }
    }
