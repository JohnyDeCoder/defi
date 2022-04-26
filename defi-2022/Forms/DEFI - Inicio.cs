using defi_2022.Classes; // Clase
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace defi_2022
{
    public partial class DEFI_Inicio : Form
    {
        public DEFI_Inicio()
        {
            InitializeComponent();

            customizeSubMenus();
        }

        private void DEFI_Inicio_Load(object sender, EventArgs e)
        {
            ColorsTheme.ChooseTheme("Default");
            panelContainerLeft.BackColor = ColorsTheme.PanelContainerLeft;
            panelForm.BackColor = ColorsTheme.PanelChildForm;
            panelSubMenuHelp.BackColor = ColorsTheme.PanelSubMenu;
            btnTrapecio.ForeColor = ColorsTheme.PrimaryFont;
            btnAyuda.ForeColor = ColorsTheme.PrimaryFont;
            btnGuia.ForeColor = ColorsTheme.PrimaryFont;
            btnAbout.ForeColor = ColorsTheme.PrimaryFont;
            btnTags.ForeColor = ColorsTheme.PrimaryFont;
            btnExit.ForeColor = ColorsTheme.PrimaryFont;
        }

        // Controls

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {


            hideSubMenu();
        }

        private void btnTrapecio_Click(object sender, EventArgs e)
        {

            hideSubMenu();
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuHelp);
        }

        private void btnGuia_Click(object sender, EventArgs e)
        {


            hideSubMenu();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {


            hideSubMenu();
        }

        private void btnTags_Click(object sender, EventArgs e)
        {


            hideSubMenu();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }

        // Methods

        private void customizeSubMenus()
        {
            panelSubMenuHelp.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelSubMenuHelp.Visible == true)
            {
                panelSubMenuHelp.Visible = false;
            }
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                panelSubMenuHelp.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }

        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                panelForm.Controls.Add(childForm);
                panelForm.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();

            }
        }
    }
}
