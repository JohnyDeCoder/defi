
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
            this.panelForm = new System.Windows.Forms.Panel();
            this.lblVersion = new System.Windows.Forms.Label();
            this.panelContainerLeft = new System.Windows.Forms.Panel();
            this.panelSubMenuOptions = new System.Windows.Forms.Panel();
            this.panelSubMenuHelp = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pbxFormLogo = new System.Windows.Forms.PictureBox();
            this.btnAdvance = new FontAwesome.Sharp.IconButton();
            this.btnLang = new FontAwesome.Sharp.IconButton();
            this.btnAppearance = new FontAwesome.Sharp.IconButton();
            this.btnOptions = new FontAwesome.Sharp.IconButton();
            this.btnTags = new FontAwesome.Sharp.IconButton();
            this.btnAbout = new FontAwesome.Sharp.IconButton();
            this.btnGuia = new FontAwesome.Sharp.IconButton();
            this.btnAyuda = new FontAwesome.Sharp.IconButton();
            this.btnIntegral = new FontAwesome.Sharp.IconButton();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.pbDEFILogo = new System.Windows.Forms.PictureBox();
            this.panelForm.SuspendLayout();
            this.panelContainerLeft.SuspendLayout();
            this.panelSubMenuOptions.SuspendLayout();
            this.panelSubMenuHelp.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFormLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDEFILogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelForm
            // 
            this.panelForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(211)))), ((int)(((byte)(251)))));
            this.panelForm.Controls.Add(this.lblVersion);
            this.panelForm.Controls.Add(this.pbxFormLogo);
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Location = new System.Drawing.Point(225, 0);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(709, 561);
            this.panelForm.TabIndex = 5;
            // 
            // lblVersion
            // 
            this.lblVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(84)))), ((int)(((byte)(122)))));
            this.lblVersion.Location = new System.Drawing.Point(620, 542);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(89, 19);
            this.lblVersion.TabIndex = 6;
            this.lblVersion.Text = "v0.0.0-beta";
            // 
            // panelContainerLeft
            // 
            this.panelContainerLeft.AutoScroll = true;
            this.panelContainerLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(137)))), ((int)(((byte)(199)))));
            this.panelContainerLeft.Controls.Add(this.panelSubMenuOptions);
            this.panelContainerLeft.Controls.Add(this.btnOptions);
            this.panelContainerLeft.Controls.Add(this.btnTags);
            this.panelContainerLeft.Controls.Add(this.panelSubMenuHelp);
            this.panelContainerLeft.Controls.Add(this.btnAyuda);
            this.panelContainerLeft.Controls.Add(this.btnIntegral);
            this.panelContainerLeft.Controls.Add(this.btnExit);
            this.panelContainerLeft.Controls.Add(this.panelLogo);
            this.panelContainerLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelContainerLeft.Location = new System.Drawing.Point(0, 0);
            this.panelContainerLeft.Name = "panelContainerLeft";
            this.panelContainerLeft.Size = new System.Drawing.Size(225, 561);
            this.panelContainerLeft.TabIndex = 4;
            // 
            // panelSubMenuOptions
            // 
            this.panelSubMenuOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(84)))), ((int)(((byte)(122)))));
            this.panelSubMenuOptions.Controls.Add(this.btnAdvance);
            this.panelSubMenuOptions.Controls.Add(this.btnLang);
            this.panelSubMenuOptions.Controls.Add(this.btnAppearance);
            this.panelSubMenuOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuOptions.Location = new System.Drawing.Point(0, 360);
            this.panelSubMenuOptions.Name = "panelSubMenuOptions";
            this.panelSubMenuOptions.Size = new System.Drawing.Size(225, 120);
            this.panelSubMenuOptions.TabIndex = 25;
            // 
            // panelSubMenuHelp
            // 
            this.panelSubMenuHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(84)))), ((int)(((byte)(122)))));
            this.panelSubMenuHelp.Controls.Add(this.btnAbout);
            this.panelSubMenuHelp.Controls.Add(this.btnGuia);
            this.panelSubMenuHelp.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuHelp.Location = new System.Drawing.Point(0, 190);
            this.panelSubMenuHelp.Name = "panelSubMenuHelp";
            this.panelSubMenuHelp.Size = new System.Drawing.Size(225, 80);
            this.panelSubMenuHelp.TabIndex = 17;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pbDEFILogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(225, 100);
            this.panelLogo.TabIndex = 0;
            // 
            // pbxFormLogo
            // 
            this.pbxFormLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbxFormLogo.Image = global::defi_2022.Properties.Resources.DEFI;
            this.pbxFormLogo.Location = new System.Drawing.Point(0, 0);
            this.pbxFormLogo.Name = "pbxFormLogo";
            this.pbxFormLogo.Size = new System.Drawing.Size(709, 561);
            this.pbxFormLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxFormLogo.TabIndex = 8;
            this.pbxFormLogo.TabStop = false;
            // 
            // btnAdvance
            // 
            this.btnAdvance.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdvance.FlatAppearance.BorderSize = 0;
            this.btnAdvance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdvance.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdvance.ForeColor = System.Drawing.Color.White;
            this.btnAdvance.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAdvance.IconColor = System.Drawing.Color.White;
            this.btnAdvance.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdvance.IconSize = 28;
            this.btnAdvance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdvance.Location = new System.Drawing.Point(0, 80);
            this.btnAdvance.Name = "btnAdvance";
            this.btnAdvance.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnAdvance.Size = new System.Drawing.Size(225, 40);
            this.btnAdvance.TabIndex = 13;
            this.btnAdvance.Text = "Avanzado";
            this.btnAdvance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdvance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdvance.UseVisualStyleBackColor = true;
            this.btnAdvance.Click += new System.EventHandler(this.btnAdvance_Click);
            // 
            // btnLang
            // 
            this.btnLang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLang.FlatAppearance.BorderSize = 0;
            this.btnLang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLang.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLang.ForeColor = System.Drawing.Color.White;
            this.btnLang.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnLang.IconColor = System.Drawing.Color.White;
            this.btnLang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLang.IconSize = 28;
            this.btnLang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLang.Location = new System.Drawing.Point(0, 40);
            this.btnLang.Name = "btnLang";
            this.btnLang.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnLang.Size = new System.Drawing.Size(225, 40);
            this.btnLang.TabIndex = 12;
            this.btnLang.Text = "Idioma";
            this.btnLang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLang.UseVisualStyleBackColor = true;
            this.btnLang.Click += new System.EventHandler(this.btnLang_Click);
            // 
            // btnAppearance
            // 
            this.btnAppearance.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAppearance.FlatAppearance.BorderSize = 0;
            this.btnAppearance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppearance.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppearance.ForeColor = System.Drawing.Color.White;
            this.btnAppearance.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAppearance.IconColor = System.Drawing.Color.White;
            this.btnAppearance.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAppearance.IconSize = 28;
            this.btnAppearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAppearance.Location = new System.Drawing.Point(0, 0);
            this.btnAppearance.Name = "btnAppearance";
            this.btnAppearance.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnAppearance.Size = new System.Drawing.Size(225, 40);
            this.btnAppearance.TabIndex = 11;
            this.btnAppearance.Text = "Apariencia";
            this.btnAppearance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAppearance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAppearance.UseVisualStyleBackColor = true;
            this.btnAppearance.Click += new System.EventHandler(this.btnAppearance_Click);
            // 
            // btnOptions
            // 
            this.btnOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOptions.FlatAppearance.BorderSize = 0;
            this.btnOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOptions.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOptions.ForeColor = System.Drawing.Color.White;
            this.btnOptions.IconChar = FontAwesome.Sharp.IconChar.Wrench;
            this.btnOptions.IconColor = System.Drawing.Color.White;
            this.btnOptions.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOptions.IconSize = 28;
            this.btnOptions.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOptions.Location = new System.Drawing.Point(0, 315);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnOptions.Size = new System.Drawing.Size(225, 45);
            this.btnOptions.TabIndex = 24;
            this.btnOptions.Text = "Opciones";
            this.btnOptions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOptions.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOptions.UseVisualStyleBackColor = true;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // btnTags
            // 
            this.btnTags.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTags.FlatAppearance.BorderSize = 0;
            this.btnTags.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTags.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTags.ForeColor = System.Drawing.Color.White;
            this.btnTags.IconChar = FontAwesome.Sharp.IconChar.Archive;
            this.btnTags.IconColor = System.Drawing.Color.White;
            this.btnTags.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTags.IconSize = 28;
            this.btnTags.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTags.Location = new System.Drawing.Point(0, 270);
            this.btnTags.Name = "btnTags";
            this.btnTags.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnTags.Size = new System.Drawing.Size(225, 45);
            this.btnTags.TabIndex = 21;
            this.btnTags.Text = "Lanzamientos";
            this.btnTags.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTags.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTags.UseVisualStyleBackColor = true;
            this.btnTags.Click += new System.EventHandler(this.btnTags_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.ForeColor = System.Drawing.Color.White;
            this.btnAbout.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAbout.IconColor = System.Drawing.Color.White;
            this.btnAbout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAbout.IconSize = 28;
            this.btnAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.Location = new System.Drawing.Point(0, 40);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnAbout.Size = new System.Drawing.Size(225, 40);
            this.btnAbout.TabIndex = 12;
            this.btnAbout.Text = "Acerca de";
            this.btnAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnGuia
            // 
            this.btnGuia.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGuia.FlatAppearance.BorderSize = 0;
            this.btnGuia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuia.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuia.ForeColor = System.Drawing.Color.White;
            this.btnGuia.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnGuia.IconColor = System.Drawing.Color.White;
            this.btnGuia.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuia.IconSize = 28;
            this.btnGuia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuia.Location = new System.Drawing.Point(0, 0);
            this.btnGuia.Name = "btnGuia";
            this.btnGuia.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnGuia.Size = new System.Drawing.Size(225, 40);
            this.btnGuia.TabIndex = 11;
            this.btnGuia.Text = "Guía de uso";
            this.btnGuia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuia.UseVisualStyleBackColor = true;
            this.btnGuia.Click += new System.EventHandler(this.btnGuia_Click);
            // 
            // btnAyuda
            // 
            this.btnAyuda.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAyuda.FlatAppearance.BorderSize = 0;
            this.btnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyuda.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAyuda.ForeColor = System.Drawing.Color.White;
            this.btnAyuda.IconChar = FontAwesome.Sharp.IconChar.Question;
            this.btnAyuda.IconColor = System.Drawing.Color.White;
            this.btnAyuda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAyuda.IconSize = 28;
            this.btnAyuda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAyuda.Location = new System.Drawing.Point(0, 145);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAyuda.Size = new System.Drawing.Size(225, 45);
            this.btnAyuda.TabIndex = 16;
            this.btnAyuda.Text = "Ayuda";
            this.btnAyuda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAyuda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAyuda.UseVisualStyleBackColor = true;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // btnIntegral
            // 
            this.btnIntegral.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnIntegral.FlatAppearance.BorderSize = 0;
            this.btnIntegral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIntegral.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIntegral.ForeColor = System.Drawing.Color.White;
            this.btnIntegral.IconChar = FontAwesome.Sharp.IconChar.SquareRootAlt;
            this.btnIntegral.IconColor = System.Drawing.Color.White;
            this.btnIntegral.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnIntegral.IconSize = 28;
            this.btnIntegral.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIntegral.Location = new System.Drawing.Point(0, 100);
            this.btnIntegral.Name = "btnIntegral";
            this.btnIntegral.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnIntegral.Size = new System.Drawing.Size(225, 45);
            this.btnIntegral.TabIndex = 14;
            this.btnIntegral.Text = "Integrar";
            this.btnIntegral.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIntegral.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIntegral.UseVisualStyleBackColor = true;
            this.btnIntegral.Click += new System.EventHandler(this.btnIntegral_Click);
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.btnExit.IconColor = System.Drawing.Color.White;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 28;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(0, 516);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnExit.Size = new System.Drawing.Size(225, 45);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Salir";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pbDEFILogo
            // 
            this.pbDEFILogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbDEFILogo.Image = global::defi_2022.Properties.Resources.DEFI;
            this.pbDEFILogo.Location = new System.Drawing.Point(0, 0);
            this.pbDEFILogo.Name = "pbDEFILogo";
            this.pbDEFILogo.Size = new System.Drawing.Size(225, 100);
            this.pbDEFILogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDEFILogo.TabIndex = 0;
            this.pbDEFILogo.TabStop = false;
            this.pbDEFILogo.Click += new System.EventHandler(this.pbDEFILogo_Click);
            // 
            // DEFI_Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.panelContainerLeft);
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "DEFI_Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DEFI - Inicio";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DEFI_Inicio_FormClosing);
            this.Load += new System.EventHandler(this.DEFI_Inicio_Load);
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            this.panelContainerLeft.ResumeLayout(false);
            this.panelSubMenuOptions.ResumeLayout(false);
            this.panelSubMenuHelp.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxFormLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDEFILogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnAyuda;
        private FontAwesome.Sharp.IconButton btnIntegral;
        private FontAwesome.Sharp.IconButton btnGuia;
        private FontAwesome.Sharp.IconButton btnTags;
        private FontAwesome.Sharp.IconButton btnExit;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.PictureBox pbxFormLogo;
        private System.Windows.Forms.Panel panelContainerLeft;
        private System.Windows.Forms.Panel panelSubMenuHelp;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnAbout;
        private FontAwesome.Sharp.IconButton btnOptions;
        private System.Windows.Forms.Panel panelSubMenuOptions;
        private FontAwesome.Sharp.IconButton btnAdvance;
        private FontAwesome.Sharp.IconButton btnLang;
        private FontAwesome.Sharp.IconButton btnAppearance;
        private System.Windows.Forms.PictureBox pbDEFILogo;
    }
}

