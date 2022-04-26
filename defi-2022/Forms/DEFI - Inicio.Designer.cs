
namespace defi_2022
{
    partial class DEFI_Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelContainerLeft = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnTrapecio = new System.Windows.Forms.Button();
            this.panelSubMenuHelp = new System.Windows.Forms.Panel();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.btnGuia = new System.Windows.Forms.Button();
            this.btnTags = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panelForm = new System.Windows.Forms.Panel();
            this.panelContainerLeft.SuspendLayout();
            this.panelSubMenuHelp.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContainerLeft
            // 
            this.panelContainerLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(137)))), ((int)(((byte)(199)))));
            this.panelContainerLeft.Controls.Add(this.btnExit);
            this.panelContainerLeft.Controls.Add(this.btnTags);
            this.panelContainerLeft.Controls.Add(this.panelSubMenuHelp);
            this.panelContainerLeft.Controls.Add(this.btnAyuda);
            this.panelContainerLeft.Controls.Add(this.btnTrapecio);
            this.panelContainerLeft.Controls.Add(this.panelLogo);
            this.panelContainerLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelContainerLeft.Location = new System.Drawing.Point(0, 0);
            this.panelContainerLeft.Name = "panelContainerLeft";
            this.panelContainerLeft.Size = new System.Drawing.Size(225, 561);
            this.panelContainerLeft.TabIndex = 0;
            // 
            // panelLogo
            // 
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(225, 100);
            this.panelLogo.TabIndex = 0;
            this.panelLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLogo_Paint);
            // 
            // btnTrapecio
            // 
            this.btnTrapecio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTrapecio.FlatAppearance.BorderSize = 0;
            this.btnTrapecio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrapecio.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrapecio.ForeColor = System.Drawing.Color.White;
            this.btnTrapecio.Location = new System.Drawing.Point(0, 100);
            this.btnTrapecio.Name = "btnTrapecio";
            this.btnTrapecio.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnTrapecio.Size = new System.Drawing.Size(225, 45);
            this.btnTrapecio.TabIndex = 1;
            this.btnTrapecio.Text = "Regla del Trapecio";
            this.btnTrapecio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrapecio.UseVisualStyleBackColor = true;
            this.btnTrapecio.Click += new System.EventHandler(this.btnTrapecio_Click);
            // 
            // panelSubMenuHelp
            // 
            this.panelSubMenuHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(84)))), ((int)(((byte)(122)))));
            this.panelSubMenuHelp.Controls.Add(this.btnAbout);
            this.panelSubMenuHelp.Controls.Add(this.btnGuia);
            this.panelSubMenuHelp.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuHelp.Location = new System.Drawing.Point(0, 190);
            this.panelSubMenuHelp.Name = "panelSubMenuHelp";
            this.panelSubMenuHelp.Size = new System.Drawing.Size(225, 81);
            this.panelSubMenuHelp.TabIndex = 2;
            // 
            // btnAyuda
            // 
            this.btnAyuda.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAyuda.FlatAppearance.BorderSize = 0;
            this.btnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyuda.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAyuda.ForeColor = System.Drawing.Color.White;
            this.btnAyuda.Location = new System.Drawing.Point(0, 145);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAyuda.Size = new System.Drawing.Size(225, 45);
            this.btnAyuda.TabIndex = 2;
            this.btnAyuda.Text = "Ayuda";
            this.btnAyuda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAyuda.UseVisualStyleBackColor = true;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // btnGuia
            // 
            this.btnGuia.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGuia.FlatAppearance.BorderSize = 0;
            this.btnGuia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuia.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuia.ForeColor = System.Drawing.Color.White;
            this.btnGuia.Location = new System.Drawing.Point(0, 0);
            this.btnGuia.Name = "btnGuia";
            this.btnGuia.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnGuia.Size = new System.Drawing.Size(225, 40);
            this.btnGuia.TabIndex = 3;
            this.btnGuia.Text = "Guía de uso";
            this.btnGuia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuia.UseVisualStyleBackColor = true;
            this.btnGuia.Click += new System.EventHandler(this.btnGuia_Click);
            // 
            // btnTags
            // 
            this.btnTags.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTags.FlatAppearance.BorderSize = 0;
            this.btnTags.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTags.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTags.ForeColor = System.Drawing.Color.White;
            this.btnTags.Location = new System.Drawing.Point(0, 271);
            this.btnTags.Name = "btnTags";
            this.btnTags.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnTags.Size = new System.Drawing.Size(225, 45);
            this.btnTags.TabIndex = 4;
            this.btnTags.Text = "Lanzamientos";
            this.btnTags.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTags.UseVisualStyleBackColor = true;
            this.btnTags.Click += new System.EventHandler(this.btnTags_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.ForeColor = System.Drawing.Color.White;
            this.btnAbout.Location = new System.Drawing.Point(0, 40);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAbout.Size = new System.Drawing.Size(225, 40);
            this.btnAbout.TabIndex = 4;
            this.btnAbout.Text = "Acerca de";
            this.btnAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(0, 516);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnExit.Size = new System.Drawing.Size(225, 45);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Salir";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panelForm
            // 
            this.panelForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(211)))), ((int)(((byte)(251)))));
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Location = new System.Drawing.Point(225, 0);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(709, 561);
            this.panelForm.TabIndex = 1;
            // 
            // DEFI_Inicio
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.panelContainerLeft);
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "DEFI_Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DEFI - Inicio";
            this.Load += new System.EventHandler(this.DEFI_Inicio_Load);
            this.panelContainerLeft.ResumeLayout(false);
            this.panelSubMenuHelp.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContainerLeft;
        private System.Windows.Forms.Panel panelSubMenuHelp;
        private System.Windows.Forms.Button btnTrapecio;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnGuia;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Button btnTags;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panelForm;
    }
}

