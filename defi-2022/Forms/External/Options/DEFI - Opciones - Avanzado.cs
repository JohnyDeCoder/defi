using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace defi_2022.Forms.External.Options
{
    public partial class DEFI_Opciones_Avanzado : Form
    {
        public DEFI_Opciones_Avanzado()
        {
            InitializeComponent();
        }

        private void DEFI_Opciones_Avanzado_Load(object sender, EventArgs e)
        {

        }

        private void timerPerformance_Tick(object sender, EventArgs e)
        {
            lblCPUCounter.Text = "Uso del CPU: " + performanceCounter.NextValue() + " %";
        }
    }
}
