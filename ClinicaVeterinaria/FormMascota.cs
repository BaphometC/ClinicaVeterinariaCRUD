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
    public partial class FormMascota : Form
    {
        public FormMascota()
        {
            InitializeComponent();
        }

        private void btnAgregarDueñoMascota_Click(object sender, EventArgs e)
        {
            FormDuenio AgregarDuenio = new FormDuenio();
            AgregarDuenio.Show();
        }

        private void btnCancelarMascota_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
