using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public enum Controles
{
SoloNumeros, SoloLetras
}

namespace ClassLibrary1
{
   public class MiControl : TextBox
    {

        protected void SoloNumeros(KeyPressEventArgs e)
        {
            if ((char.IsNumber(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = false;
                return;

            }
            e.Handled = true;
        }

        protected void SoloLetras(KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
            e.Handled = false;
        }
        

    }
}
