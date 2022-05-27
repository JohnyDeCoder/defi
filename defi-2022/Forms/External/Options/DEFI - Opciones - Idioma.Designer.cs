
namespace defi_2022.Forms.External.Options
{
    partial class DEFI_Opciones_Idioma
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
            this.panelLang = new System.Windows.Forms.Panel();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.panelLang.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLang
            // 
            this.panelLang.Controls.Add(this.groupBox10);
            this.panelLang.Controls.Add(this.iconButton5);
            this.panelLang.Controls.Add(this.label5);
            this.panelLang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLang.Location = new System.Drawing.Point(0, 0);
            this.panelLang.Name = "panelLang";
            this.panelLang.Size = new System.Drawing.Size(800, 450);
            this.panelLang.TabIndex = 18;
            // 
            // groupBox10
            // 
            this.groupBox10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox10.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox10.Location = new System.Drawing.Point(271, 45);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(517, 468);
            this.groupBox10.TabIndex = 37;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Idioma";
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(800, 45);
            this.label5.TabIndex = 32;
            this.label5.Text = "I  D  I  O  M  A";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iconButton5
            // 
            this.iconButton5.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.iconButton5.IconColor = System.Drawing.Color.Black;
            this.iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton5.IconSize = 20;
            this.iconButton5.Location = new System.Drawing.Point(432, 519);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Size = new System.Drawing.Size(91, 30);
            this.iconButton5.TabIndex = 35;
            this.iconButton5.Text = "Aplicar";
            this.iconButton5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton5.UseVisualStyleBackColor = true;
            // 
            // DEFI_Opciones_Idioma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelLang);
            this.Name = "DEFI_Opciones_Idioma";
            this.Text = "DEFI___Opciones___Idioma";
            this.Load += new System.EventHandler(this.DEFI_Opciones_Idioma_Load);
            this.panelLang.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLang;
        private System.Windows.Forms.GroupBox groupBox10;
        private FontAwesome.Sharp.IconButton iconButton5;
        private System.Windows.Forms.Label label5;
    }
}