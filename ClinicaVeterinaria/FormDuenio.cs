using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaVeterinaria
{
    public partial class FormDuenio : Form
    {
        public FormDuenio()
        {
            InitializeComponent();
        }

        private void btnCancelarDueño_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
