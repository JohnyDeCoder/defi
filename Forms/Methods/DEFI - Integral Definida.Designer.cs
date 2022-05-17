
namespace defi_2022.Forms
{
    partial class DEFI_Integral_Definida
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DEFI_Integral_Definida));
            this.ttipTxtBox = new System.Windows.Forms.ToolTip(this.components);
            this.numericRound = new System.Windows.Forms.NumericUpDown();
            this.txtFX = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.ttipBtn = new System.Windows.Forms.ToolTip(this.components);
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSigns = new System.Windows.Forms.Button();
            this.btnEuler = new System.Windows.Forms.Button();
            this.btnPow = new System.Windows.Forms.Button();
            this.ttipOptions = new System.Windows.Forms.ToolTip(this.components);
            this.rbRedondear = new System.Windows.Forms.RadioButton();
            this.rbNormal = new System.Windows.Forms.RadioButton();
            this.cbSinEA = new System.Windows.Forms.CheckBox();
            this.lblMethodName = new System.Windows.Forms.Label();
            this.gbOptions = new System.Windows.Forms.GroupBox();
            this.gbTipoResult = new System.Windows.Forms.GroupBox();
            this.tabControlSolutions = new System.Windows.Forms.TabControl();
            this.pagePasos = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.picPaso3 = new System.Windows.Forms.PictureBox();
            this.picPaso4 = new System.Windows.Forms.PictureBox();
            this.picPaso1 = new System.Windows.Forms.PictureBox();
            this.picPaso2 = new System.Windows.Forms.PictureBox();
            this.pageGraphic = new System.Windows.Forms.TabPage();
            this.gbResult = new System.Windows.Forms.GroupBox();
            this.picResult = new System.Windows.Forms.PictureBox();
            this.gbValues = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picIntegral = new System.Windows.Forms.PictureBox();
            this.lblMODE = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picGraphic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericRound)).BeginInit();
            this.gbOptions.SuspendLayout();
            this.gbTipoResult.SuspendLayout();
            this.tabControlSolutions.SuspendLayout();
            this.pagePasos.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPaso3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPaso4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPaso1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPaso2)).BeginInit();
            this.pageGraphic.SuspendLayout();
            this.gbResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).BeginInit();
            this.gbValues.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIntegral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGraphic)).BeginInit();
            this.SuspendLayout();
            // 
            // ttipTxtBox
            // 
            this.ttipTxtBox.AutoPopDelay = 15000;
            this.ttipTxtBox.InitialDelay = 3000;
            this.ttipTxtBox.IsBalloon = true;
            this.ttipTxtBox.ReshowDelay = 100;
            this.ttipTxtBox.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttipTxtBox.ToolTipTitle = "Ayuda con Campos de Texto";
            // 
            // numericRound
            // 
            this.numericRound.AutoSize = true;
            this.numericRound.Enabled = false;
            this.numericRound.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericRound.Location = new System.Drawing.Point(99, 55);
            this.numericRound.Name = "numericRound";
            this.numericRound.Size = new System.Drawing.Size(52, 26);
            this.numericRound.TabIndex = 9;
            this.ttipTxtBox.SetToolTip(this.numericRound, resources.GetString("numericRound.ToolTip"));
            this.numericRound.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // txtFX
            // 
            this.txtFX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFX.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFX.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtFX.Location = new System.Drawing.Point(104, 101);
            this.txtFX.Name = "txtFX";
            this.txtFX.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtFX.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtFX.Size = new System.Drawing.Size(347, 36);
            this.txtFX.TabIndex = 0;
            this.txtFX.Text = "x^2";
            this.ttipTxtBox.SetToolTip(this.txtFX, "• Escriba la fórmula\r\n\r\n• Ejemplos:\r\n   • x^3-x-1\r\n   • (ℯ^x+1)/(√(x))\r\n   • (ℯ^x" +
        "^-x)/(ℯ^x^x^x)\r\n   • 1/2 + sin(π / 4) + (sin(3x)2 + cos(3x)2)\r\n");
            this.txtFX.TextChanged += new System.EventHandler(this.txtFX_TextChanged);
            // 
            // txtB
            // 
            this.txtB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtB.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtB.Location = new System.Drawing.Point(58, 22);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(40, 36);
            this.txtB.TabIndex = 4;
            this.txtB.Text = "1";
            this.txtB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ttipTxtBox.SetToolTip(this.txtB, "• Escriba el intérvalo b  → [a, b].\r\n\r\n• Información:\r\n   Recuerde que los valore" +
        "s del intérvalo\r\n   deben ser de distintos signos.");
            // 
            // txtA
            // 
            this.txtA.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtA.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtA.Location = new System.Drawing.Point(58, 171);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(40, 36);
            this.txtA.TabIndex = 5;
            this.txtA.Text = "0";
            this.txtA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ttipTxtBox.SetToolTip(this.txtA, "• Escriba el intérvalo b  → [a, b].\r\n\r\n• Información:\r\n   Recuerde que los valore" +
        "s del intérvalo\r\n   deben ser de distintos signos.");
            // 
            // ttipBtn
            // 
            this.ttipBtn.AutoPopDelay = 15000;
            this.ttipBtn.InitialDelay = 3000;
            this.ttipBtn.IsBalloon = true;
            this.ttipBtn.ReshowDelay = 100;
            this.ttipBtn.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttipBtn.ToolTipTitle = "Ayuda con Botones";
            // 
            // btnReset
            // 
            this.btnReset.AutoSize = true;
            this.btnReset.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(12, 124);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(179, 63);
            this.btnReset.TabIndex = 27;
            this.btnReset.Text = "Reiniciar";
            this.ttipBtn.SetToolTip(this.btnReset, "Reiniciar / Limpiar\r\n\r\n• Función: \r\n   Limpia todos los campos de texto y resulta" +
        "dos.\r\n");
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.AutoSize = true;
            this.btnCalculate.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnCalculate.Location = new System.Drawing.Point(12, 12);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(175, 106);
            this.btnCalculate.TabIndex = 26;
            this.btnCalculate.Text = "Calcular";
            this.ttipBtn.SetToolTip(this.btnCalculate, "Calcular\r\n\r\n• Función: \r\n   Calcula por el método seleccionado a partir de los \r\n" +
        "    valores que proporcione.");
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 28);
            this.button1.TabIndex = 33;
            this.button1.Text = "Refrescar";
            this.ttipBtn.SetToolTip(this.button1, "Reiniciar / Limpiar\r\n\r\n• Función: \r\n   Limpia todos los campos de texto y resulta" +
        "dos.\r\n");
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnSigns
            // 
            this.btnSigns.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSigns.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSigns.Location = new System.Drawing.Point(420, 20);
            this.btnSigns.Name = "btnSigns";
            this.btnSigns.Size = new System.Drawing.Size(74, 36);
            this.btnSigns.TabIndex = 3;
            this.btnSigns.Text = "Signos";
            this.ttipBtn.SetToolTip(this.btnSigns, resources.GetString("btnSigns.ToolTip"));
            this.btnSigns.UseVisualStyleBackColor = true;
            // 
            // btnEuler
            // 
            this.btnEuler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEuler.Font = new System.Drawing.Font("Trebuchet MS", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEuler.Location = new System.Drawing.Point(346, 20);
            this.btnEuler.Name = "btnEuler";
            this.btnEuler.Padding = new System.Windows.Forms.Padding(3, 0, 0, 4);
            this.btnEuler.Size = new System.Drawing.Size(32, 37);
            this.btnEuler.TabIndex = 1;
            this.btnEuler.Text = "ℯ";
            this.ttipBtn.SetToolTip(this.btnEuler, "Símbolo de Euler ℯ\r\n\r\n• Función: \r\n   Imprime ℯ al campo de la función.\r\n\r\n• Valo" +
        "r:\r\n    ℯ = 2.718281828\r\n\r\n• Aplicación:\r\n    ℯ^n ó ℯn");
            this.btnEuler.UseVisualStyleBackColor = true;
            // 
            // btnPow
            // 
            this.btnPow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPow.Font = new System.Drawing.Font("Trebuchet MS", 20.25F);
            this.btnPow.Location = new System.Drawing.Point(384, 21);
            this.btnPow.Name = "btnPow";
            this.btnPow.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnPow.Size = new System.Drawing.Size(30, 36);
            this.btnPow.TabIndex = 2;
            this.btnPow.Text = "^";
            this.ttipBtn.SetToolTip(this.btnPow, "Símbolo de Potencia\r\n\r\n• Función: \r\n   Imprime ^ al campo de la función.\r\n\r\n• Apl" +
        "icación:\r\n    a^b = aᵇ");
            this.btnPow.UseVisualStyleBackColor = true;
            // 
            // ttipOptions
            // 
            this.ttipOptions.AutoPopDelay = 15000;
            this.ttipOptions.InitialDelay = 3000;
            this.ttipOptions.IsBalloon = true;
            this.ttipOptions.ReshowDelay = 100;
            this.ttipOptions.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttipOptions.ToolTipTitle = "Ayuda con Opciones";
            // 
            // rbRedondear
            // 
            this.rbRedondear.AutoSize = true;
            this.rbRedondear.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRedondear.Location = new System.Drawing.Point(6, 47);
            this.rbRedondear.Name = "rbRedondear";
            this.rbRedondear.Size = new System.Drawing.Size(87, 40);
            this.rbRedondear.TabIndex = 8;
            this.rbRedondear.Text = "Redondear\r\ndecimales";
            this.ttipOptions.SetToolTip(this.rbRedondear, "Redondear a n decimales\r\n\r\n• Información:\r\n   Toma el número del cuadro de número" +
        "\r\n   de la derecha y redondea los valores.");
            this.rbRedondear.UseVisualStyleBackColor = true;
            // 
            // rbNormal
            // 
            this.rbNormal.AutoSize = true;
            this.rbNormal.Checked = true;
            this.rbNormal.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNormal.Location = new System.Drawing.Point(6, 19);
            this.rbNormal.Name = "rbNormal";
            this.rbNormal.Size = new System.Drawing.Size(67, 22);
            this.rbNormal.TabIndex = 10;
            this.rbNormal.TabStop = true;
            this.rbNormal.Text = "Normal";
            this.ttipOptions.SetToolTip(this.rbNormal, "Resultado sin alterar\r\n\r\n• Información:\r\n   No altera el resultado.");
            this.rbNormal.UseVisualStyleBackColor = true;
            // 
            // cbSinEA
            // 
            this.cbSinEA.AutoSize = true;
            this.cbSinEA.Checked = true;
            this.cbSinEA.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSinEA.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSinEA.Location = new System.Drawing.Point(6, 19);
            this.cbSinEA.Name = "cbSinEA";
            this.cbSinEA.Size = new System.Drawing.Size(143, 22);
            this.cbSinEA.TabIndex = 11;
            this.cbSinEA.Text = "Mostrar Gráficaᴮᴱᵀᴬ";
            this.ttipOptions.SetToolTip(this.cbSinEA, resources.GetString("cbSinEA.ToolTip"));
            this.cbSinEA.UseVisualStyleBackColor = true;
            // 
            // lblMethodName
            // 
            this.lblMethodName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMethodName.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMethodName.Location = new System.Drawing.Point(222, 9);
            this.lblMethodName.Name = "lblMethodName";
            this.lblMethodName.Size = new System.Drawing.Size(463, 29);
            this.lblMethodName.TabIndex = 31;
            this.lblMethodName.Text = "I  N  T  E  G  R  A  L    D  E  F  I  N  I  D  A";
            this.lblMethodName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbOptions
            // 
            this.gbOptions.AutoSize = true;
            this.gbOptions.Controls.Add(this.cbSinEA);
            this.gbOptions.Controls.Add(this.gbTipoResult);
            this.gbOptions.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOptions.Location = new System.Drawing.Point(12, 193);
            this.gbOptions.Name = "gbOptions";
            this.gbOptions.Size = new System.Drawing.Size(179, 161);
            this.gbOptions.TabIndex = 28;
            this.gbOptions.TabStop = false;
            this.gbOptions.Text = "Opciones";
            // 
            // gbTipoResult
            // 
            this.gbTipoResult.Controls.Add(this.numericRound);
            this.gbTipoResult.Controls.Add(this.rbRedondear);
            this.gbTipoResult.Controls.Add(this.rbNormal);
            this.gbTipoResult.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTipoResult.Location = new System.Drawing.Point(6, 47);
            this.gbTipoResult.Name = "gbTipoResult";
            this.gbTipoResult.Size = new System.Drawing.Size(162, 95);
            this.gbTipoResult.TabIndex = 15;
            this.gbTipoResult.TabStop = false;
            this.gbTipoResult.Text = "Tipo de Resultado";
            // 
            // tabControlSolutions
            // 
            this.tabControlSolutions.Controls.Add(this.pagePasos);
            this.tabControlSolutions.Controls.Add(this.pageGraphic);
            this.tabControlSolutions.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlSolutions.Location = new System.Drawing.Point(12, 360);
            this.tabControlSolutions.Name = "tabControlSolutions";
            this.tabControlSolutions.SelectedIndex = 0;
            this.tabControlSolutions.ShowToolTips = true;
            this.tabControlSolutions.Size = new System.Drawing.Size(685, 189);
            this.tabControlSolutions.TabIndex = 32;
            // 
            // pagePasos
            // 
            this.pagePasos.Controls.Add(this.tableLayoutPanel1);
            this.pagePasos.Location = new System.Drawing.Point(4, 27);
            this.pagePasos.Name = "pagePasos";
            this.pagePasos.Padding = new System.Windows.Forms.Padding(3);
            this.pagePasos.Size = new System.Drawing.Size(677, 158);
            this.pagePasos.TabIndex = 0;
            this.pagePasos.Text = "Pasos y Solución";
            this.pagePasos.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.picPaso3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.picPaso4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.picPaso1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.picPaso2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(671, 152);
            this.tableLayoutPanel1.TabIndex = 36;
            // 
            // picPaso3
            // 
            this.picPaso3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picPaso3.Location = new System.Drawing.Point(3, 79);
            this.picPaso3.Name = "picPaso3";
            this.picPaso3.Size = new System.Drawing.Size(329, 70);
            this.picPaso3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPaso3.TabIndex = 35;
            this.picPaso3.TabStop = false;
            // 
            // picPaso4
            // 
            this.picPaso4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picPaso4.Location = new System.Drawing.Point(338, 79);
            this.picPaso4.Name = "picPaso4";
            this.picPaso4.Size = new System.Drawing.Size(330, 70);
            this.picPaso4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPaso4.TabIndex = 34;
            this.picPaso4.TabStop = false;
            // 
            // picPaso1
            // 
            this.picPaso1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picPaso1.Location = new System.Drawing.Point(3, 3);
            this.picPaso1.Name = "picPaso1";
            this.picPaso1.Size = new System.Drawing.Size(329, 70);
            this.picPaso1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPaso1.TabIndex = 33;
            this.picPaso1.TabStop = false;
            // 
            // picPaso2
            // 
            this.picPaso2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picPaso2.Location = new System.Drawing.Point(338, 3);
            this.picPaso2.Name = "picPaso2";
            this.picPaso2.Size = new System.Drawing.Size(330, 70);
            this.picPaso2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPaso2.TabIndex = 36;
            this.picPaso2.TabStop = false;
            // 
            // pageGraphic
            // 
            this.pageGraphic.BackColor = System.Drawing.Color.Transparent;
            this.pageGraphic.Controls.Add(this.button1);
            this.pageGraphic.Controls.Add(this.picGraphic);
            this.pageGraphic.Location = new System.Drawing.Point(4, 27);
            this.pageGraphic.Name = "pageGraphic";
            this.pageGraphic.Padding = new System.Windows.Forms.Padding(3);
            this.pageGraphic.Size = new System.Drawing.Size(677, 158);
            this.pageGraphic.TabIndex = 1;
            this.pageGraphic.Text = "Gráficaᴮᴱᵀᴬ";
            this.pageGraphic.UseVisualStyleBackColor = true;
            // 
            // gbResult
            // 
            this.gbResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbResult.Controls.Add(this.picResult);
            this.gbResult.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbResult.Location = new System.Drawing.Point(6, 218);
            this.gbResult.Name = "gbResult";
            this.gbResult.Size = new System.Drawing.Size(488, 89);
            this.gbResult.TabIndex = 16;
            this.gbResult.TabStop = false;
            this.gbResult.Text = "Resultado";
            // 
            // picResult
            // 
            this.picResult.Location = new System.Drawing.Point(6, 19);
            this.picResult.Name = "picResult";
            this.picResult.Size = new System.Drawing.Size(476, 64);
            this.picResult.TabIndex = 0;
            this.picResult.TabStop = false;
            // 
            // gbValues
            // 
            this.gbValues.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbValues.Controls.Add(this.label1);
            this.gbValues.Controls.Add(this.lblA);
            this.gbValues.Controls.Add(this.lblMODE);
            this.gbValues.Controls.Add(this.pictureBox1);
            this.gbValues.Controls.Add(this.txtFX);
            this.gbValues.Controls.Add(this.btnPow);
            this.gbValues.Controls.Add(this.btnEuler);
            this.gbValues.Controls.Add(this.btnSigns);
            this.gbValues.Controls.Add(this.gbResult);
            this.gbValues.Controls.Add(this.txtA);
            this.gbValues.Controls.Add(this.txtB);
            this.gbValues.Controls.Add(this.picIntegral);
            this.gbValues.Font = new System.Drawing.Font("Trebuchet MS", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbValues.Location = new System.Drawing.Point(197, 41);
            this.gbValues.Name = "gbValues";
            this.gbValues.Size = new System.Drawing.Size(500, 313);
            this.gbValues.TabIndex = 29;
            this.gbValues.TabStop = false;
            this.gbValues.Text = "Valores";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::defi_2022.Properties.Resources.dx;
            this.pictureBox1.Location = new System.Drawing.Point(457, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // picIntegral
            // 
            this.picIntegral.Image = global::defi_2022.Properties.Resources.integral;
            this.picIntegral.Location = new System.Drawing.Point(39, 64);
            this.picIntegral.Name = "picIntegral";
            this.picIntegral.Size = new System.Drawing.Size(59, 102);
            this.picIntegral.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIntegral.TabIndex = 28;
            this.picIntegral.TabStop = false;
            // 
            // lblMODE
            // 
            this.lblMODE.AutoSize = true;
            this.lblMODE.BackColor = System.Drawing.Color.Transparent;
            this.lblMODE.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMODE.Location = new System.Drawing.Point(104, 82);
            this.lblMODE.Name = "lblMODE";
            this.lblMODE.Size = new System.Drawing.Size(51, 16);
            this.lblMODE.TabIndex = 30;
            this.lblMODE.Text = "GRADOS";
            this.ttipTxtBox.SetToolTip(this.lblMODE, "Radianes\r\n\r\n• Información:\r\n   Calcula la función en RADIANES\r\n   ÚNICAMENTE si e" +
        "xiste una función \r\n   trigonométrica en el campo de texto.");
            // 
            // lblA
            // 
            this.lblA.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA.Location = new System.Drawing.Point(8, 24);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(44, 28);
            this.lblA.TabIndex = 31;
            this.lblA.Text = "B =";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 28);
            this.label1.TabIndex = 32;
            this.label1.Text = "A =";
            // 
            // picGraphic
            // 
            this.picGraphic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picGraphic.Location = new System.Drawing.Point(3, 3);
            this.picGraphic.Name = "picGraphic";
            this.picGraphic.Size = new System.Drawing.Size(671, 152);
            this.picGraphic.TabIndex = 34;
            this.picGraphic.TabStop = false;
            // 
            // DEFI_Integral_Definida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 561);
            this.Controls.Add(this.tabControlSolutions);
            this.Controls.Add(this.lblMethodName);
            this.Controls.Add(this.gbValues);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.gbOptions);
            this.Controls.Add(this.btnCalculate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DEFI_Integral_Definida";
            this.Text = "DEFI - Integral Definida";
            this.Load += new System.EventHandler(this.DEFI_Integral_Definida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericRound)).EndInit();
            this.gbOptions.ResumeLayout(false);
            this.gbOptions.PerformLayout();
            this.gbTipoResult.ResumeLayout(false);
            this.gbTipoResult.PerformLayout();
            this.tabControlSolutions.ResumeLayout(false);
            this.pagePasos.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPaso3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPaso4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPaso1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPaso2)).EndInit();
            this.pageGraphic.ResumeLayout(false);
            this.pageGraphic.PerformLayout();
            this.gbResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).EndInit();
            this.gbValues.ResumeLayout(false);
            this.gbValues.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIntegral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGraphic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip ttipTxtBox;
        private System.Windows.Forms.ToolTip ttipBtn;
        private System.Windows.Forms.ToolTip ttipOptions;
        private System.Windows.Forms.Label lblMethodName;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox gbOptions;
        private System.Windows.Forms.GroupBox gbTipoResult;
        private System.Windows.Forms.NumericUpDown numericRound;
        private System.Windows.Forms.RadioButton rbRedondear;
        private System.Windows.Forms.RadioButton rbNormal;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.CheckBox cbSinEA;
        private System.Windows.Forms.TabControl tabControlSolutions;
        private System.Windows.Forms.TabPage pagePasos;
        private System.Windows.Forms.TabPage pageGraphic;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox picPaso3;
        private System.Windows.Forms.PictureBox picPaso4;
        private System.Windows.Forms.PictureBox picPaso1;
        private System.Windows.Forms.PictureBox picPaso2;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox txtFX;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.GroupBox gbResult;
        private System.Windows.Forms.PictureBox picResult;
        private System.Windows.Forms.Button btnSigns;
        private System.Windows.Forms.Button btnEuler;
        private System.Windows.Forms.Button btnPow;
        private System.Windows.Forms.GroupBox gbValues;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picIntegral;
        private System.Windows.Forms.Label lblMODE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.PictureBox picGraphic;
    }
}