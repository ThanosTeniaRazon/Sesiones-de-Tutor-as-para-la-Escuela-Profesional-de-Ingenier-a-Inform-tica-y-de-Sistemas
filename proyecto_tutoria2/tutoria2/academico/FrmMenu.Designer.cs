namespace academico
{
    partial class FrmMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registroDeCarrerasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeAlumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeCursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroTutoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SeaGreen;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroDeCarrerasToolStripMenuItem,
            this.registroDeAlumnosToolStripMenuItem,
            this.registroDeCursosToolStripMenuItem,
            this.registroTutoriaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(751, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registroDeCarrerasToolStripMenuItem
            // 
            this.registroDeCarrerasToolStripMenuItem.Name = "registroDeCarrerasToolStripMenuItem";
            this.registroDeCarrerasToolStripMenuItem.Size = new System.Drawing.Size(161, 24);
            this.registroDeCarrerasToolStripMenuItem.Text = "Registro de Alumnos";
            this.registroDeCarrerasToolStripMenuItem.Click += new System.EventHandler(this.registroDeCarrerasToolStripMenuItem_Click);
            // 
            // registroDeAlumnosToolStripMenuItem
            // 
            this.registroDeAlumnosToolStripMenuItem.Name = "registroDeAlumnosToolStripMenuItem";
            this.registroDeAlumnosToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            this.registroDeAlumnosToolStripMenuItem.Text = "Registro de Docentes";
            this.registroDeAlumnosToolStripMenuItem.Click += new System.EventHandler(this.registroDeAlumnosToolStripMenuItem_Click);
            // 
            // registroDeCursosToolStripMenuItem
            // 
            this.registroDeCursosToolStripMenuItem.Name = "registroDeCursosToolStripMenuItem";
            this.registroDeCursosToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.registroDeCursosToolStripMenuItem.Text = "Asignacion";
            this.registroDeCursosToolStripMenuItem.Click += new System.EventHandler(this.registroDeCursosToolStripMenuItem_Click);
            // 
            // registroTutoriaToolStripMenuItem
            // 
            this.registroTutoriaToolStripMenuItem.Name = "registroTutoriaToolStripMenuItem";
            this.registroTutoriaToolStripMenuItem.Size = new System.Drawing.Size(129, 24);
            this.registroTutoriaToolStripMenuItem.Text = "Registro Tutoria";
            this.registroTutoriaToolStripMenuItem.Click += new System.EventHandler(this.registroTutoriaToolStripMenuItem_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(751, 356);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMenu";
            this.Text = "FrmMenu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registroDeCarrerasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeAlumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeCursosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroTutoriaToolStripMenuItem;
    }
}