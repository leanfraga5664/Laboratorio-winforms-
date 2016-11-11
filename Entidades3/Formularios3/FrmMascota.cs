using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades3;

namespace Formularios3
{
    public partial class FrmMascota : FrmAnimal
    {
        public FrmMascota()
        {
            InitializeComponent();

            foreach(string tipo in Enum.GetNames(typeof(eTipoDeMascota)))
                {
                combo_tipoMascota.Items.Add(tipo);

            }
            combo_tipoMascota.SelectedIndex = 1;
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
