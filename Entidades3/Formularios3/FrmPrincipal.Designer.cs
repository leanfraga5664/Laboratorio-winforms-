namespace Formularios3
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Alta_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Baja_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Modificacion_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.combo_menu = new System.Windows.Forms.ToolStripComboBox();
            this.Ordenar_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Salir_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 51);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(462, 186);
            this.listBox1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Alta_Menu,
            this.Baja_menu,
            this.Modificacion_menu,
            this.combo_menu,
            this.Ordenar_menu,
            this.Salir_Menu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(511, 27);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // Alta_Menu
            // 
            this.Alta_Menu.Name = "Alta_Menu";
            this.Alta_Menu.Size = new System.Drawing.Size(38, 23);
            this.Alta_Menu.Text = "alta";
            this.Alta_Menu.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // Baja_menu
            // 
            this.Baja_menu.Name = "Baja_menu";
            this.Baja_menu.Size = new System.Drawing.Size(41, 23);
            this.Baja_menu.Text = "Baja";
            // 
            // Modificacion_menu
            // 
            this.Modificacion_menu.Name = "Modificacion_menu";
            this.Modificacion_menu.Size = new System.Drawing.Size(89, 23);
            this.Modificacion_menu.Text = "Modificacion";
            // 
            // combo_menu
            // 
            this.combo_menu.Name = "combo_menu";
            this.combo_menu.Size = new System.Drawing.Size(121, 23);
            // 
            // Ordenar_menu
            // 
            this.Ordenar_menu.Name = "Ordenar_menu";
            this.Ordenar_menu.Size = new System.Drawing.Size(62, 23);
            this.Ordenar_menu.Text = "Ordenar";
            this.Ordenar_menu.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // Salir_Menu
            // 
            this.Salir_Menu.Name = "Salir_Menu";
            this.Salir_Menu.Size = new System.Drawing.Size(41, 23);
            this.Salir_Menu.Text = "Salir";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 252);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.Text = "FrmPrincipal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Alta_Menu;
        private System.Windows.Forms.ToolStripMenuItem Baja_menu;
        private System.Windows.Forms.ToolStripMenuItem Modificacion_menu;
        private System.Windows.Forms.ToolStripComboBox combo_menu;
        private System.Windows.Forms.ToolStripMenuItem Ordenar_menu;
        private System.Windows.Forms.ToolStripMenuItem Salir_Menu;
    }
}