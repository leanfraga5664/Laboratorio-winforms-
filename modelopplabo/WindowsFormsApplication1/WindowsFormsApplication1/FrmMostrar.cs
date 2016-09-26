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

public delegate void ActualizarLista(List<Mascota> masc);


namespace WindowsFormsApplication1
{
    public partial class FrmMostrar : Form
    {
        public FrmMostrar()
        {
            InitializeComponent();
        }

        private void FrmMostrar_Load(object sender, EventArgs e)
        {
            FrmPrincipal frmP = (FrmPrincipal)Owner;
            this.FormBorderStyle = FormBorderStyle.None;

        }

        public void ActualizarListados(List<Mascota> masc)
        {
            lstMostrar.Items.Clear();
            foreach (Mascota masco in masc)
            {
                this.lstMostrar.Items.Add(masco);
            }

        }
    }
}
