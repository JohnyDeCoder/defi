using defi_2022.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace defi_2022.Forms.External
{
    public partial class DEFI_Opciones_Apariencia : Form
    {
        public DEFI_Opciones_Apariencia()
        {
            InitializeComponent();
        }

        private void DEFI_Opciones_Load(object sender, EventArgs e)
        {
            ColorsTheme.ChooseTheme(Properties.Settings.Default.Theme);

            string actualTheme = Properties.Settings.Default.Theme;
            string actualImageText = Properties.Settings.Default.FontImageText;
            double actualNumImageScale = Properties.Settings.Default.ImageScale;

            // Appearence Panel

            if (actualTheme == "Blue")
            {
                rbAzul.Checked = true;
            }
            else if (actualTheme == "Red")
            {
                rbRojo.Checked = true;
            }
            else if (actualTheme == "Green")
            {
                rbVerde.Checked = true;
            }
            else
            {
                rbMorado.Checked = true;
            }

            numImageScale.Value = (decimal)actualNumImageScale;

            cbImageText.Text = actualImageText;
        }

        private void btnApplyAppearance_Click(object sender, EventArgs e)
        {
            if (rbAzul.Checked == true)
            {
                Properties.Settings.Default.Theme = "Blue";
            }
            else if (rbRojo.Checked == true)
            {
                Properties.Settings.Default.Theme = "Red";
            }
            else if (rbVerde.Checked == true)
            {
                Properties.Settings.Default.Theme = "Green";
            }
            else
            {
                Properties.Settings.Default.Theme = "Purple";
            }

            Properties.Settings.Default.ImageScale = (double)numImageScale.Value;

            Properties.Settings.Default.FontImageText = cbImageText.Text;

            MessageBox.Show("Para aplicar correctamente los cambios debe reiniciar la aplicación.", "Cambios aplicados", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }
    }
}
