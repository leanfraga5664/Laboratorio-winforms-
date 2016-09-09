using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {
        private int numero1 = 0, numero2 = 0, Op = 0;

        public int NRo1
        {
            get { return this.numero1; }
            set { this.numero1 = value; }
        }
        public int NRo2
        {
            get { return this.numero2; }
            set { this.numero2 = value; }
        }
        public int OP
        {
            get { return this.Op; }
            set { this.Op = value; }
        }
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            deshabilitar_op();
            Deshabilitarigual();
            foreach (Control item in this.groupBox_numeros.Controls)
            {
                if (item is Button)
                    item.Click += new EventHandler(numeroPulsado);
            }

        }

        private void numeroPulsado(object sender, EventArgs e)
        {
           
            Button boton = (Button)sender;
            if (sender == button_1)
            {
                textBox.Text += "1";
                if (NRo1 == 0)
                    NRo1 = 1;
                else
                {
                    NRo2 = 1;
                    deshabilitarTodo();
                    habilitarigual();
                }
                    
            }
            if (sender == button_2)
            {
                textBox.Text += "2";
                if (NRo1 == 0)
                    NRo1 = 2;
                else
                {
                    NRo2 = 2;
                    deshabilitarTodo();
                    habilitarigual();
                }
            }
            if (sender == button_3)
            {
                textBox.Text += "3";
                if (NRo1 == 0)
                    NRo1 = 3;
                else
                {
                    NRo2 = 3;
                    deshabilitarTodo();
                    habilitarigual();
                }
            }
            if (sender == button_4)
            {
                textBox.Text += "4";
                if (NRo1 == 0)
                    NRo1 = 4;
                else
                {
                    NRo2 = 4;
                    deshabilitarTodo();
                    habilitarigual();
                }
            }
            if (sender == button_5)
            {
                textBox.Text += "5";
                  if (NRo1 == 0)
                    NRo1 = 5;
                else
                  {
                      NRo2 = 5;
                      deshabilitarTodo();
                      habilitarigual();
                  }
            }
            if (sender == button_6)
            {
                textBox.Text += "6";
                if (NRo1 == 0)
                    NRo1 = 6;
                else
                {
                    NRo2 = 6;
                    deshabilitarTodo();
                    habilitarigual();
                }
            }
            if (sender == button_7)
            {
                textBox.Text += "7";
                if (NRo1 == 0)
                    NRo1 = 7;
                else
                {
                    NRo2 = 7;
                    deshabilitarTodo();
                    habilitarigual();
                }
            }
            if (sender == button_8)
            {
                textBox.Text += "8";
                if (NRo1 == 0)
                    NRo1 = 8;
                else
                {
                    NRo2 = 8;
                    deshabilitarTodo();
                    habilitarigual();
                }
            }
            if (sender == button_9)
            {
                textBox.Text += "9";
                if (NRo1 == 0)
                    NRo1 = 9;
                else
                {
                    NRo2 = 9;
                    deshabilitarTodo();
                    habilitarigual();
                }
            }
            deshabilitar_numeros();
            habilitar_op();
        }
        private void Op_pulsado(object sender, EventArgs e)
        {
            Button operacion=(Button)sender;
            if (operacion == btn_suma)
            {
                this.OP = 1;
                textBox.Text += "+";
            }
            if (operacion == btn_resta)
            {
                this.OP = 2;
                textBox.Text += "-";
            }
            if (operacion == btn_mult)
            {
                this.OP = 3;
                textBox.Text += "*";
            }
            if (operacion == btn_div)
            {
                this.OP = 4;
                textBox.Text += "/";
            }
            deshabilitar_op();
            habilitar_numeros();
        }

        private void deshabilitar_numeros()
        {
            foreach (Control item in this.groupBox_numeros.Controls)
            {
                if (item is Button)
                    item.Click -= new EventHandler(numeroPulsado);
            }
         

            foreach (Control item in this.groupBox_numeros.Controls)
            {
                var a = Button.DefaultFont;

                if (item is Button)
                    item.BackColor = Color.Gray;
            
            }
        }
        private void habilitar_numeros()
        {
            foreach (Control item in this.groupBox_numeros.Controls)
            {
                if (item is Button)
                    item.Click += new EventHandler(numeroPulsado);
            }
            foreach (Control item in this.groupBox_numeros.Controls)
            {
                var a = Button.DefaultFont;

                if (item is Button)
                    item.BackColor = Button.DefaultBackColor;

            }
    
        }
        private void deshabilitar_op()
        {
            foreach (Control item in this.groupBox_op.Controls)
            {
                if (item is Button)
                    item.Click -= new EventHandler(Op_pulsado);
            }


            foreach (Control item in this.groupBox_op.Controls)
            {
                if (item is Button)
                    item.BackColor = Color.Gray;
            }
        }
        private void habilitar_op()
        {
            foreach (Control item in this.groupBox_op.Controls)
            {
                if (item is Button)
                    item.Click += new EventHandler(Op_pulsado);
            }
            foreach (Control item in this.groupBox_op.Controls)
            {
                var a = Button.DefaultFont;

                if (item is Button)
                    item.BackColor = Button.DefaultBackColor;

            }

        }
        private void deshabilitarTodo()
        {
            deshabilitar_op();
            deshabilitar_numeros();
            habilitarigual();
        }
        private void habilitarigual()
        {

            this.btn_igual.BackColor = Button.DefaultBackColor;
            this.btn_igual.Click += new EventHandler(calcular);
 
        }
        private void calcular(object sender, EventArgs e)
        {
            if (Op == 1)
            {
                textBox.Text =( NRo1 + NRo2).ToString();
            }
            if (Op == 2)
            {
                textBox.Text = (NRo1 - NRo2).ToString();
            }
            if (Op == 3)
            {
                textBox.Text = (NRo1 * NRo2).ToString();
            }
            if (Op == 4)
            {
                textBox.Text = (NRo1 / NRo2).ToString();
            }
            deshabilitarTodo();
        }
        private void Deshabilitarigual()
        {
            this.btn_igual.BackColor = Color.Gray;
        }

        private void btn_igual_Click(object sender, EventArgs e)
        {

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            this.NRo1 = 0;
            this.NRo2 = 0;
            habilitar_numeros();
            this.textBox.Text = " ";
            deshabilitar_op();
            Deshabilitarigual();
            
        }

    }
}
