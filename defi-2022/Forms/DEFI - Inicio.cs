using defi_2022.Classes; // Clase
using defi_2022.Forms;
using defi_2022.Forms.External;
using defi_2022.Forms.External.Options;
using FontAwesome.Sharp;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace defi_2022
{
    public partial class DEFI_Inicio : Form
    {
        // Campos
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form activeForm;

        public DEFI_Inicio()
        {
            InitializeComponent();

            customizeSubMenus();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(8, 45);
            panelContainerLeft.Controls.Add(leftBorderBtn);
        }

        private void DEFI_Inicio_Load(object sender, EventArgs e)
        {
            ColorsTheme.ChooseTheme(Properties.Settings.Default.Theme);
            // Left Panel
            panelContainerLeft.BackColor = ColorsTheme.PanelContainerLeft;

            // Child Form
            panelForm.BackColor = ColorsTheme.PanelChildForm;

            //SubMenus
            panelSubMenuHelp.BackColor = ColorsTheme.PanelSubMenu;
            panelSubMenuOptions.BackColor = ColorsTheme.PanelSubMenu;

            // Buttons Font
            btnIntegral.ForeColor = ColorsTheme.PrimaryFont; // Integral Definida Button
            btnAyuda.ForeColor = ColorsTheme.PrimaryFont; // Help Button
            btnGuia.ForeColor = ColorsTheme.PrimaryFont;
            btnAbout.ForeColor = ColorsTheme.PrimaryFont;
            btnTags.ForeColor = ColorsTheme.PrimaryFont; // Tags Button
            btnExit.ForeColor = ColorsTheme.PrimaryFont; // Exit Button

            // Labels
            lblVersion.ForeColor = ColorsTheme.PanelSubMenu;
            //lblSeparator.BackColor = ColorsTheme.PanelSubMenu;
            //lblSeparator.ForeColor = ColorsTheme.PanelSubMenu;

            if (!Directory.Exists("Equations"))
            {
                Directory.CreateDirectory("Equations");
            }
        }

        #region Controles
        // Controls

        private void DEFI_Inicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Desea salir de la aplicación?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                Properties.Settings.Default.Counter = 0; // Reinicia el contador al cerrar

                Properties.Settings.Default.Save(); // Guardas cambios.

                e.Cancel = false;
            }
        }

        private void pbDEFILogo_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnIntegral_Click(object sender, EventArgs e)
        {
            if (Text != "DEFI - Integral Definida")
            {
                openChildForm(new DEFI_Integral_Definida());
            }

            activateBtn(sender);
            hideSubMenu();
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuHelp);
            activateBtn(sender);
        }

        private void btnGuia_Click(object sender, EventArgs e)
        {
            using (Process compiler = new Process())
            {
                compiler.StartInfo.FileName = "https://github.com/JohnyDeCoder/defi#guía-de-uso";
                compiler.StartInfo.UseShellExecute = true;
                compiler.Start();
            }

            hideSubMenu();
            activateBtn(sender);
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            hideSubMenu();

            //Form DEFI_About = new DEFI_About(currentTheme);
            //DEFI_About.ShowDialog();

            Reset();
        }

        private void btnTags_Click(object sender, EventArgs e)
        {
            using (Process compiler = new Process())
            {
                compiler.StartInfo.FileName = "https://github.com/JohnyDeCoder/defi/tags";
                compiler.StartInfo.UseShellExecute = true;
                compiler.Start();
            }

            hideSubMenu();
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuOptions);
            activateBtn(sender);
        }

        private void btnAppearance_Click(object sender, EventArgs e)
        {
            if (Text != "DEFI - Opciones - Apariencia")
            {
                openChildForm(new DEFI_Opciones_Apariencia());
            }

            hideSubMenu();
        }

        private void btnLang_Click(object sender, EventArgs e)
        {
            if (Text != "DEFI - Opciones - Idioma")
            {
                openChildForm(new DEFI_Opciones_Idioma());
            }

            hideSubMenu();
        }

        private void btnAdvance_Click(object sender, EventArgs e)
        {
            if (Text != "DEFI - Opciones - Avanzado")
            {
                openChildForm(new DEFI_Opciones_Avanzado());
            }

            hideSubMenu();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region Métodos
        // Methods

        private void customizeSubMenus()
        {
            panelSubMenuHelp.Visible = false;
            panelSubMenuOptions.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelSubMenuHelp.Visible == true)
            {
                panelSubMenuHelp.Visible = false;
            }
            if (panelSubMenuOptions.Visible == true)
            {
                panelSubMenuOptions.Visible = false;
            }
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelForm.Controls.Add(childForm);
            panelForm.Tag = childForm;
            childForm.BringToFront();
            Text = childForm.Text;
            childForm.Show();
        }

        private void activateBtn(object senderBtn)
        {
            if (senderBtn != null)
            {
                disableBtn();

                // Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = ColorsTheme.btnActivated;
                currentBtn.ForeColor = ColorsTheme.PrimaryFontSelected;
                currentBtn.IconColor = ColorsTheme.PrimaryFontSelected;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                //currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleCenter;

                // Left border button
                leftBorderBtn.BackColor = ColorsTheme.leftBorderButton;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }

        private void disableBtn()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = ColorsTheme.PanelContainerLeft;
                currentBtn.ForeColor = ColorsTheme.PrimaryFont;
                currentBtn.IconColor = ColorsTheme.PrimaryFont;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void Reset()
        {
            if (activeForm != null)
            {
                activeForm.Close();
                Text = "DEFI - Inicio";
            }
            disableBtn();
            leftBorderBtn.Visible = false;
        }
        #endregion
    }
}
