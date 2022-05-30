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
    public partial class FormCita : Form
    {
        public FormCita()
        {
            InitializeComponent();
        }

        private void btnRegistrarMascotaCita_Click(object sender, EventArgs e)
        {
            FormMascota AgregarMascota = new FormMascota();
            AgregarMascota.Show();
        }

        private void btnCancelarCita_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
