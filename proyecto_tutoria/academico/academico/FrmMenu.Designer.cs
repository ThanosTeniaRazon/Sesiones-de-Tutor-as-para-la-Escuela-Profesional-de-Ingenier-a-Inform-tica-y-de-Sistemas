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
            this.registroDeMatriculaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SeaGreen;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroDeCarrerasToolStripMenuItem,
            this.registroDeAlumnosToolStripMenuItem,
            this.registroDeCursosToolStripMenuItem,
            this.registroDeMatriculaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(563, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registroDeCarrerasToolStripMenuItem
            // 
            this.registroDeCarrerasToolStripMenuItem.Name = "registroDeCarrerasToolStripMenuItem";
            this.registroDeCarrerasToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.registroDeCarrerasToolStripMenuItem.Text = "Registro de carreras";
            this.registroDeCarrerasToolStripMenuItem.Click += new System.EventHandler(this.registroDeCarrerasToolStripMenuItem_Click);
            // 
            // registroDeAlumnosToolStripMenuItem
            // 
            this.registroDeAlumnosToolStripMenuItem.Name = "registroDeAlumnosToolStripMenuItem";
            this.registroDeAlumnosToolStripMenuItem.Size = new System.Drawing.Size(127, 20);
            this.registroDeAlumnosToolStripMenuItem.Text = "Registro de alumnos";
            this.registroDeAlumnosToolStripMenuItem.Click += new System.EventHandler(this.registroDeAlumnosToolStripMenuItem_Click);
            // 
            // registroDeCursosToolStripMenuItem
            // 
            this.registroDeCursosToolStripMenuItem.Name = "registroDeCursosToolStripMenuItem";
            this.registroDeCursosToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.registroDeCursosToolStripMenuItem.Text = "Registro de cursos";
            this.registroDeCursosToolStripMenuItem.Click += new System.EventHandler(this.registroDeCursosToolStripMenuItem_Click);
            // 
            // registroDeMatriculaToolStripMenuItem
            // 
            this.registroDeMatriculaToolStripMenuItem.Name = "registroDeMatriculaToolStripMenuItem";
            this.registroDeMatriculaToolStripMenuItem.Size = new System.Drawing.Size(131, 20);
            this.registroDeMatriculaToolStripMenuItem.Text = "Registro de matricula";
            this.registroDeMatriculaToolStripMenuItem.Click += new System.EventHandler(this.registroDeMatriculaToolStripMenuItem_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(563, 289);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
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
        private System.Windows.Forms.ToolStripMenuItem registroDeMatriculaToolStripMenuItem;
    }
}