using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AngouriMath;
using defi_2022.Classes;

namespace defi_2022.Forms
{
    public partial class DEFI_Integral_Definida : Form
    {
        // Campos
        private TextBox currentTxtBox;
        public bool txtEmpty; // Variable utilizada para saber si hay algún TextBox vacio.
        public bool txtContains; // Variable utilizada para saber si hay algún TextBox únicamente con - o .
        private string currentForm; // Variable utilizada para guardar el Name del formulario padre
        public bool error; // Variable utilizada para detectar un error

        public DEFI_Integral_Definida(string currentTheme)
        {
            ColorsTheme.ChooseTheme(currentTheme);

            InitializeComponent();
        }

        private void DEFI_Integral_Definida_Load(object sender, EventArgs e)
        {

        }

        // Functions

        private double function(double x)
        {
            return 0;
        }

        // Controls

        private void btnCalculate_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea reiniciar los valores?", "Reiniciar", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Reset();
            }
        }

        private void txtFX_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumbersAndFunctions(sender, e);

            if (char.IsSeparator(e.KeyChar)) // No imprime un espacio en blanco
            {
                e.Handled = true;
            }

            // Envía un TAB al precionar enter
            //if (e.KeyChar == (char)Keys.Enter)
            //{
            //    e.Handled = true;
            //    SendKeys.Send("{TAB}");
            //}
        }

        private void txtFX_TextChanged(object sender, EventArgs e)
        {
            txtFX.CharacterCasing = CharacterCasing.Lower; // Solo aceptar minúsculas

            if (txtFX.Text.Contains("e"))
            {
                txtFX.Text = txtFX.Text.Replace("e", "ℯ^");
                txtFX.Select(txtFX.Text.Length, 0);
            }

            if (txtFX.Text.Contains("sin") || txtFX.Text.Contains("cos") ||
                txtFX.Text.Contains("tan") || txtFX.Text.Contains("sin⁻¹") ||
                txtFX.Text.Contains("cos⁻¹") || txtFX.Text.Contains("tan⁻¹"))
            {
                lblMODE.Text = "RADIANES";
            }
            else
            {
                lblMODE.Text = "GRADOS";
            }
        }

        private void btnEuler_Click(object sender, EventArgs e)
        {
            txtFX.Text += "ℯ^";
        }

        private void btnPow_Click(object sender, EventArgs e)
        {
            txtFX.Text += "^";
        }

        private void txtA_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumbersAndCharts(sender, e);
        }

        private void txtB_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumbersAndCharts(sender, e);
        }

        private void btnSigns_Click(object sender, EventArgs e)
        {
            //Form ROOTPROX_Signos = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "ROOTPROX_Signos").SingleOrDefault<Form>();

            //if (ROOTPROX_Signos != null)
            //{
            //    ROOTPROX_Signos.BringToFront();
            //}
            //else
            //{
            //    currentForm = GetType().Name; // Obtiene el nombre del formulario padre
            //    ROOTPROX_Signos formSigns = new ROOTPROX_Signos(currentForm);
            //    AddOwnedForm(formSigns);
            //    formSigns.Show();
            //}
        }

        private void rbRedondear_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRedondear.Checked == true)
            {
                numericRound.Enabled = true;
            }
            else
            {
                numericRound.Enabled = false;
            }
        }

        // Methods

        private void Reset()
        {
            //dgvResults.Rows.Clear();
            //dgvResults.Refresh();

            //dgvResultAprox.Rows.Clear();
            //dgvResultAprox.Refresh();

            //txtFX.Text = "x";
            //txtA.Text = "0";
            //txtB.Text = "1";
            //txtNmax.Text = "20";
            //txtE.Text = "0.01";
        }

        // Validation

        private void onlyNumbersAndCharts(object senderTxtBox, KeyPressEventArgs e)
        {
            currentTxtBox = (TextBox)senderTxtBox;

            // Solo aceptar dígitos, punto decimal y guión de resta.
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)
                && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            // Para que acepte un solo punto decimal.
            if ((e.KeyChar == '.') && (currentTxtBox.Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            // Para que acepte un solo punto guión de resta.
            if ((e.KeyChar == '-') && (currentTxtBox.Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }
        }

        private void onlyNumbersAndFunctions(object senderTxtBox, KeyPressEventArgs e)
        {
            currentTxtBox = (TextBox)senderTxtBox;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)
                && (e.KeyChar != '.') && (e.KeyChar != '-')
                && (e.KeyChar != '+') && (e.KeyChar != '*')
                && (e.KeyChar != 'e') && (e.KeyChar != '(')
                && (e.KeyChar != ')') && (e.KeyChar != 'x')
                && (e.KeyChar != '^') && (e.KeyChar != '/'))
            {
                e.Handled = true;
            }
        }

        private void txtBoxEmpty(Control ROOTPROX_Bisección)
        {
            // Busca cada TextBox dentro del formulario.
            foreach (Control oControls in ROOTPROX_Bisección.Controls)
            {
                // Si encuentra un TextBox vacío.
                if (oControls is TextBox & oControls.Enabled == true & oControls.Text == string.Empty)
                {
                    txtEmpty = true;
                }
            }
        }

        private void txtBoxContains(Control gbValues)
        {
            // Busca cada TextBox dentro del groupBox - Valores.
            foreach (Control oControls in gbValues.Controls)
            {
                // Si encuentra un TextBox con únicamente un - o punto o ambos juntos.
                if (oControls is TextBox & oControls.Enabled == true & oControls.Text == "-" || oControls.Text == "." ||
                    oControls.Text.Contains("-.") || oControls.Text.Contains(".-") ||
                    oControls.Text.EndsWith("-"))
                {
                    txtContains = true;
                }
            }
        }
    }
}
