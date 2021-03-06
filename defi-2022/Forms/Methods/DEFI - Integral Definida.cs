using defi_2022.Classes;
using defi_2022.Forms.External;
using System;
using System.Drawing;
using System.Windows.Forms;
using AngouriMath.Extensions;
using AngouriMath;
using System.Linq;

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

        public DEFI_Integral_Definida()
        {
            ColorsTheme.ChooseTheme(Properties.Settings.Default.Theme);

            InitializeComponent();
        }

        private void DEFI_Integral_Definida_Load(object sender, EventArgs e)
        {
            
        }

        // Controls

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int round, counter;
            double a, b, evalDouble;
            string expression = txtFX.Text;

            counter = Properties.Settings.Default.Counter;

            a = double.Parse(txtA.Text);
            b = double.Parse(txtB.Text);

            switch (expression)
            {
                case var euler when expression.Contains("ℯ"):
                    expression = expression.Replace("ℯ", "e");
                    break;
                case var sqrt when expression.Contains("√"):
                    expression = expression.Replace("√", "sqrt");
                    break;
                case var pi when expression.Contains("π"):
                    expression = expression.Replace("π", "pi");
                    break;
                case var arcsin when expression.Contains("sin⁻¹"):
                    expression = expression.Replace("sin⁻¹", "arcsin");
                    break;
                case var arccos when expression.Contains("cos⁻¹"):
                    expression = expression.Replace("cos⁻¹", "arccos");
                    break;
                case var arctan when expression.Contains("tan⁻¹"):
                    expression = expression.Replace("tan⁻¹", "arctan");
                    break;
            }

            // Escribe la fórmula sin integrar

            picPaso1.Image = new Bitmap(ConvertToLatex.CreateEquation("\\int_{" + a + "}^{" + b + "}\\left[" + expression.Latexise() + "\\right] dx", counter++));

            Entity integral = expression.Integrate("x").Simplify();

            // Escribe la fórmula integrada ya simplificada

            picPaso2.Image = new Bitmap(ConvertToLatex.CreateEquation("\\int_{" + a + "}^{" + b + "}\\left[" + integral.Latexise() + "\\right] \\vert_{" + a + "}^{" + b + "}", counter++));

            string integralPartA = integral.ToString();
            string integralPartB = integral.ToString();

            switch (integralPartA)
            {
                case var euler when integralPartA.Contains("ℯ"):
                    integralPartA = integralPartA.Replace("ℯ", "e");
                    break;
                case var sqrt when integralPartA.Contains("√"):
                    integralPartA = integralPartA.Replace("√", "sqrt");
                    break;
                case var pi when integralPartA.Contains("π"):
                    integralPartA = integralPartA.Replace("π", "pi");
                    break;
                case var arcsin when integralPartA.Contains("sin⁻¹"):
                    integralPartA = integralPartA.Replace("sin⁻¹", "arcsin");
                    break;
                case var arccos when integralPartA.Contains("cos⁻¹"):
                    integralPartA = integralPartA.Replace("cos⁻¹", "arccos");
                    break;
                case var arctan when integralPartA.Contains("tan⁻¹"):
                    integralPartA = integralPartA.Replace("tan⁻¹", "arctan");
                    break;
                case var xValue when integralPartA.Contains("x"):
                    integralPartA = integralPartA.Replace("x", a.ToString());
                    break;
            }

            switch (integralPartB)
            {
                case var euler when integralPartB.Contains("ℯ"):
                    integralPartB = integralPartB.Replace("ℯ", "e");
                    break;
                case var sqrt when integralPartB.Contains("√"):
                    integralPartB = integralPartA.Replace("√", "sqrt");
                    break;
                case var pi when integralPartB.Contains("π"):
                    integralPartB = integralPartB.Replace("π", "pi");
                    break;
                case var arcsin when integralPartB.Contains("sin⁻¹"):
                    integralPartB = integralPartB.Replace("sin⁻¹", "arcsin");
                    break;
                case var arccos when integralPartB.Contains("cos⁻¹"):
                    integralPartB = integralPartB.Replace("cos⁻¹", "arccos");
                    break;
                case var arctan when integralPartB.Contains("tan⁻¹"):
                    integralPartB = integralPartB.Replace("tan⁻¹", "arctan");
                    break;
                case var xValue when integralPartB.Contains("x"):
                    integralPartB = integralPartB.Replace("x", b.ToString());
                    break;
            }

            // Resta del límite inferior con el superior

            // Si es ln...
            if (integralPartB.Contains("ln") || integralPartA.Contains("ln"))
            {
                string calculateLn;
                string[] partInferiorA, partInferiorB;

                partInferiorA = expression.Split('/');
                partInferiorB = expression.Split('/');

                partInferiorA[1] = partInferiorA[1].Replace("x", a.ToString());
                partInferiorB[1] = partInferiorB[1].Replace("x", b.ToString());

                picPaso3.Image = new Bitmap(ConvertToLatex.CreateEquation("-ln\\left[\\left|" + partInferiorA[1].Latexise() + "\\right|\\right] + ln\\left[\\left|" + partInferiorB[1].Latexise() + "\\right|\\right]", counter++));

                calculateLn = "-ln(" + partInferiorA[1] + ") - (-ln(" + partInferiorB[1] + "))";

                if (rbRedondear.Checked == true)
                {
                    round = Convert.ToInt32(Math.Round(numericRound.Value, 0));

                    evalDouble = (double)calculateLn.EvalNumerical();
                    evalDouble = Math.Round(evalDouble, round);

                    // Resultado final en unidades cuadradas

                    picPaso4.Image = new Bitmap(ConvertToLatex.CreateEquation("Result \\approx " + evalDouble.ToString().Latexise() + "u^{2}", counter++));
                }
                else
                {
                    evalDouble = (double)calculateLn.EvalNumerical();

                    // Resultado final en unidades cuadradas

                    picPaso4.Image = new Bitmap(ConvertToLatex.CreateEquation("Result \\approx " + evalDouble.ToString().Latexise() + "u^{2}", counter++));
                }
            }
            else
            {
                picPaso3.Image = new Bitmap(ConvertToLatex.CreateEquation("\\left[" + integralPartB.Latexise() + "\\right] - \\left[" + integralPartA.Latexise() + "\\right]", counter++));

                if (rbRedondear.Checked == true)
                {
                    round = Convert.ToInt32(Math.Round(numericRound.Value, 0));

                    evalDouble = (double)(integralPartB.EvalNumerical() - integralPartA.EvalNumerical());
                    evalDouble = Math.Round(evalDouble, round);

                    // Resultado final en unidades cuadradas

                    picPaso4.Image = new Bitmap(ConvertToLatex.CreateEquation("Result \\approx " + evalDouble.ToString().Latexise() + "u^{2}", counter++));
                }
                else
                {
                    evalDouble = (double)(integralPartB.EvalNumerical() - integralPartA.EvalNumerical());

                    // Resultado final en unidades cuadradas

                    picPaso4.Image = new Bitmap(ConvertToLatex.CreateEquation("Result \\approx " + evalDouble.ToString().Latexise() + "u^{2}", counter++));
                }
            }
            try
            {

            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);

                if (err.Message.Contains("no viable alternative at input"))
                {
                    MessageBox.Show(
                    "Ocurrió un error inesperado, por favor escriba la función correctamente.\n\n" +
                    "Si necesitas ayuda, por favor da click en el botón AYUDA para obtener más información.\n\n" +
                    "Código: ERR100",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    0, "https://github.com/JohnyDeCoder/rootprox#err100"
                    );
                }

                if (err.Message.Contains("mismatched input"))
                {
                    MessageBox.Show(
                    "Ocurrió un error inesperado, por favor no escriba signos o símbolos repetidos.\n\n" +
                    "Si necesitas ayuda, por favor da click en el botón AYUDA para obtener más información.\n\n" +
                    "Código: ERR101",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    0, "https://github.com/JohnyDeCoder/rootprox#err101"
                    );
                }

                if (err.Message.Contains("extraneous input"))
                {
                    MessageBox.Show(
                    "Ocurrió un error inesperado, por favor escriba la función correctamente.\n\n" +
                    "Si necesitas ayuda, por favor da click en el botón AYUDA para obtener más información.\n\n" +
                    "Código: ERR102",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    0, "https://github.com/JohnyDeCoder/rootprox#err102"
                    );
                }

                if (err.Message.Contains("Cannot cast from AngouriMath.Entity+Number+Complex to System.Double"))
                {
                    MessageBox.Show(
                    "Ocurrió un error inesperado, la función es muy compleja para su solución.\n\n" +
                    "Si necesitas ayuda, por favor da click en el botón AYUDA para obtener más información.\n\n" +
                    "Código: ERR103",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    0, "https://github.com/JohnyDeCoder/rootprox#err103"
                    );
                }

                if (err.Message.Contains("Result cannot be represented as a simple number!"))
                {
                    MessageBox.Show(
                    "Ocurrió un error inesperado, por favor escriba la función correctamente.\n\n" +
                    "Si necesitas ayuda, por favor da click en el botón AYUDA para obtener más información.\n\n" +
                    "Código: ERR104",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    0, "https://github.com/JohnyDeCoder/rootprox#err104"
                    );
                }

                if (err.Message.Contains("token recognition error at"))
                {
                    MessageBox.Show(
                    "Ocurrió un error inesperado, por favor escriba la función correctamente.\n\n" +
                    "Si necesitas ayuda, por favor da click en el botón AYUDA para obtener más información.\n\n" +
                    "Código: ERR105",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    0, "https://github.com/JohnyDeCoder/rootprox#err105"
                    );
                }
            }
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
            Form DEFI_Signos = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "DEFI_Signos").SingleOrDefault<Form>();

            if (DEFI_Signos != null)
            {
                DEFI_Signos.BringToFront();
            }
            else
            {
                currentForm = GetType().Name; // Obtiene el nombre del formulario padre
                DEFI_Signos formSigns = new DEFI_Signos(currentForm);
                AddOwnedForm(formSigns);
                formSigns.Show();
            }
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

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"Equations\");
        }

        // Methods

        private void Reset()
        {
            txtFX.Text = "x";
            txtA.Text = "0";
            txtB.Text = "1";
        }

        // Validation

        private void onlyNumbersAndCharts(object senderTxtBox, KeyPressEventArgs e)
        {
            currentTxtBox = (TextBox)senderTxtBox;

            // Solo aceptar dígitos, punto decimal y guión de resta.
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)
                && (e.KeyChar != '.'))
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
