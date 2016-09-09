namespace calculadora
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox_txt = new System.Windows.Forms.GroupBox();
            this.groupBox_numeros = new System.Windows.Forms.GroupBox();
            this.groupBox_op = new System.Windows.Forms.GroupBox();
            this.btn_igual = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.button_1 = new System.Windows.Forms.Button();
            this.button_2 = new System.Windows.Forms.Button();
            this.button_3 = new System.Windows.Forms.Button();
            this.button_4 = new System.Windows.Forms.Button();
            this.button_5 = new System.Windows.Forms.Button();
            this.button_6 = new System.Windows.Forms.Button();
            this.button_7 = new System.Windows.Forms.Button();
            this.button_8 = new System.Windows.Forms.Button();
            this.button_9 = new System.Windows.Forms.Button();
            this.btn_suma = new System.Windows.Forms.Button();
            this.btn_resta = new System.Windows.Forms.Button();
            this.btn_mult = new System.Windows.Forms.Button();
            this.btn_div = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.btn_salir = new System.Windows.Forms.Button();
            this.groupBox_txt.SuspendLayout();
            this.groupBox_numeros.SuspendLayout();
            this.groupBox_op.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_txt
            // 
            this.groupBox_txt.Controls.Add(this.textBox);
            this.groupBox_txt.Location = new System.Drawing.Point(39, 23);
            this.groupBox_txt.Name = "groupBox_txt";
            this.groupBox_txt.Size = new System.Drawing.Size(349, 73);
            this.groupBox_txt.TabIndex = 0;
            this.groupBox_txt.TabStop = false;
            // 
            // groupBox_numeros
            // 
            this.groupBox_numeros.Controls.Add(this.button_9);
            this.groupBox_numeros.Controls.Add(this.button_8);
            this.groupBox_numeros.Controls.Add(this.button_6);
            this.groupBox_numeros.Controls.Add(this.button_7);
            this.groupBox_numeros.Controls.Add(this.button_5);
            this.groupBox_numeros.Controls.Add(this.button_4);
            this.groupBox_numeros.Controls.Add(this.button_3);
            this.groupBox_numeros.Controls.Add(this.button_2);
            this.groupBox_numeros.Controls.Add(this.button_1);
            this.groupBox_numeros.Location = new System.Drawing.Point(39, 118);
            this.groupBox_numeros.Name = "groupBox_numeros";
            this.groupBox_numeros.Size = new System.Drawing.Size(215, 192);
            this.groupBox_numeros.TabIndex = 1;
            this.groupBox_numeros.TabStop = false;
            // 
            // groupBox_op
            // 
            this.groupBox_op.Controls.Add(this.btn_div);
            this.groupBox_op.Controls.Add(this.btn_mult);
            this.groupBox_op.Controls.Add(this.btn_resta);
            this.groupBox_op.Controls.Add(this.btn_suma);
            this.groupBox_op.Location = new System.Drawing.Point(295, 118);
            this.groupBox_op.Name = "groupBox_op";
            this.groupBox_op.Size = new System.Drawing.Size(121, 179);
            this.groupBox_op.TabIndex = 2;
            this.groupBox_op.TabStop = false;
            // 
            // btn_igual
            // 
            this.btn_igual.Location = new System.Drawing.Point(295, 302);
            this.btn_igual.Name = "btn_igual";
            this.btn_igual.Size = new System.Drawing.Size(101, 23);
            this.btn_igual.TabIndex = 3;
            this.btn_igual.Text = "=";
            this.btn_igual.UseVisualStyleBackColor = true;
            this.btn_igual.Click += new System.EventHandler(this.btn_igual_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(295, 331);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(127, 24);
            this.btn_limpiar.TabIndex = 4;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // button_1
            // 
            this.button_1.Location = new System.Drawing.Point(6, 19);
            this.button_1.Name = "button_1";
            this.button_1.Size = new System.Drawing.Size(48, 23);
            this.button_1.TabIndex = 0;
            this.button_1.Text = "1";
            this.button_1.UseVisualStyleBackColor = true;
            // 
            // button_2
            // 
            this.button_2.Location = new System.Drawing.Point(60, 19);
            this.button_2.Name = "button_2";
            this.button_2.Size = new System.Drawing.Size(55, 23);
            this.button_2.TabIndex = 1;
            this.button_2.Text = "2";
            this.button_2.UseVisualStyleBackColor = true;
            // 
            // button_3
            // 
            this.button_3.Location = new System.Drawing.Point(136, 19);
            this.button_3.Name = "button_3";
            this.button_3.Size = new System.Drawing.Size(50, 23);
            this.button_3.TabIndex = 5;
            this.button_3.Text = "3";
            this.button_3.UseVisualStyleBackColor = true;
            // 
            // button_4
            // 
            this.button_4.Location = new System.Drawing.Point(6, 64);
            this.button_4.Name = "button_4";
            this.button_4.Size = new System.Drawing.Size(48, 23);
            this.button_4.TabIndex = 6;
            this.button_4.Text = "4";
            this.button_4.UseVisualStyleBackColor = true;
            // 
            // button_5
            // 
            this.button_5.Location = new System.Drawing.Point(60, 64);
            this.button_5.Name = "button_5";
            this.button_5.Size = new System.Drawing.Size(55, 23);
            this.button_5.TabIndex = 7;
            this.button_5.Text = "5";
            this.button_5.UseVisualStyleBackColor = true;
            // 
            // button_6
            // 
            this.button_6.Location = new System.Drawing.Point(136, 64);
            this.button_6.Name = "button_6";
            this.button_6.Size = new System.Drawing.Size(50, 23);
            this.button_6.TabIndex = 5;
            this.button_6.Text = "6";
            this.button_6.UseVisualStyleBackColor = true;
            // 
            // button_7
            // 
            this.button_7.Location = new System.Drawing.Point(6, 117);
            this.button_7.Name = "button_7";
            this.button_7.Size = new System.Drawing.Size(48, 23);
            this.button_7.TabIndex = 8;
            this.button_7.Text = "7";
            this.button_7.UseVisualStyleBackColor = true;
            // 
            // button_8
            // 
            this.button_8.Location = new System.Drawing.Point(60, 112);
            this.button_8.Name = "button_8";
            this.button_8.Size = new System.Drawing.Size(55, 28);
            this.button_8.TabIndex = 9;
            this.button_8.Text = "8";
            this.button_8.UseVisualStyleBackColor = true;
            // 
            // button_9
            // 
            this.button_9.Location = new System.Drawing.Point(137, 113);
            this.button_9.Name = "button_9";
            this.button_9.Size = new System.Drawing.Size(49, 26);
            this.button_9.TabIndex = 6;
            this.button_9.Text = "9";
            this.button_9.UseVisualStyleBackColor = true;
            // 
            // btn_suma
            // 
            this.btn_suma.BackColor = System.Drawing.SystemColors.Control;
            this.btn_suma.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_suma.Location = new System.Drawing.Point(17, 19);
            this.btn_suma.Name = "btn_suma";
            this.btn_suma.Size = new System.Drawing.Size(76, 21);
            this.btn_suma.TabIndex = 0;
            this.btn_suma.Text = "+";
            this.btn_suma.UseVisualStyleBackColor = false;
            // 
            // btn_resta
            // 
            this.btn_resta.BackColor = System.Drawing.SystemColors.Control;
            this.btn_resta.Location = new System.Drawing.Point(18, 62);
            this.btn_resta.Name = "btn_resta";
            this.btn_resta.Size = new System.Drawing.Size(75, 23);
            this.btn_resta.TabIndex = 1;
            this.btn_resta.Text = "-";
            this.btn_resta.UseVisualStyleBackColor = false;
            // 
            // btn_mult
            // 
            this.btn_mult.Location = new System.Drawing.Point(17, 101);
            this.btn_mult.Name = "btn_mult";
            this.btn_mult.Size = new System.Drawing.Size(76, 32);
            this.btn_mult.TabIndex = 2;
            this.btn_mult.Text = "*";
            this.btn_mult.UseVisualStyleBackColor = true;
            // 
            // btn_div
            // 
            this.btn_div.Location = new System.Drawing.Point(16, 139);
            this.btn_div.Name = "btn_div";
            this.btn_div.Size = new System.Drawing.Size(77, 29);
            this.btn_div.TabIndex = 3;
            this.btn_div.Text = "/";
            this.btn_div.UseVisualStyleBackColor = true;
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(20, 29);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(311, 20);
            this.textBox.TabIndex = 0;
            this.textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(39, 332);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 23);
            this.btn_salir.TabIndex = 5;
            this.btn_salir.Text = "salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 379);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_igual);
            this.Controls.Add(this.groupBox_op);
            this.Controls.Add(this.groupBox_numeros);
            this.Controls.Add(this.groupBox_txt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_txt.ResumeLayout(false);
            this.groupBox_txt.PerformLayout();
            this.groupBox_numeros.ResumeLayout(false);
            this.groupBox_op.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_txt;
        private System.Windows.Forms.GroupBox groupBox_numeros;
        private System.Windows.Forms.Button button_8;
        private System.Windows.Forms.Button button_7;
        private System.Windows.Forms.Button button_5;
        private System.Windows.Forms.Button button_4;
        private System.Windows.Forms.Button button_3;
        private System.Windows.Forms.Button button_2;
        private System.Windows.Forms.Button button_1;
        private System.Windows.Forms.GroupBox groupBox_op;
        private System.Windows.Forms.Button btn_igual;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button button_6;
        private System.Windows.Forms.Button button_9;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button btn_div;
        private System.Windows.Forms.Button btn_mult;
        private System.Windows.Forms.Button btn_resta;
        private System.Windows.Forms.Button btn_suma;
        private System.Windows.Forms.Button btn_salir;
    }
}

