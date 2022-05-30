using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace ClinicaVeterinaria
{
    public partial class ViewRecepcion : Form
    {
        public ViewRecepcion()
        {
            InitializeComponent();
        }

        private void BtnVistaClientes_Click(object sender, EventArgs e)
        {
            ViewMascotas VistaMascotas = new ViewMascotas();
            VistaMascotas.ShowDialog();
        }

        private void BtnVistaDoctores_Click(object sender, EventArgs e)
        {
            ViewDoctores VistaDoctores = new ViewDoctores();
            VistaDoctores.ShowDialog();
        }

        private void BtnVistaCitas_Click(object sender, EventArgs e)
        {
            ViewCitas VistaCitas = new ViewCitas();
            VistaCitas.ShowDialog();
        }

        private void ViewRecepcion_Load(object sender, EventArgs e)
        {
            lblIDRecepcionista.Text = LoginController.recepcionistadatos.IdRecepcionista.ToString();
            lblNombreRecepcionista.Text = LoginController.recepcionistadatos.Nombre + " " + LoginController.recepcionistadatos.Apellido;
        }

        private void gbRecepcionista_Enter(object sender, EventArgs e)
        {

        }
    }
}
