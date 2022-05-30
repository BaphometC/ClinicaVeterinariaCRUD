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
using Entidad;
using Newtonsoft.Json;
using System.Data.Entity;

namespace ClinicaVeterinaria
{
    public partial class ViewCitas : Form
    {
        public ViewCitas()
        {
            InitializeComponent();
        }

        private void ViewCitas_Load(object sender, EventArgs e)
        {
            var ListaCita = CitaController.getCita();
            dgvListaCitas.DataSource = ListaCita;
            dgvListaCitas.Columns["Receta"].Visible = false;
            dgvListaCitas.Columns["Doctor"].Visible = false;
            dgvListaCitas.Columns["HistorialCitas"].Visible = false;
            dgvListaCitas.Columns["Mascota"].Visible = false;
            dgvListaCitas.Columns["Recepcionista"].Visible = false;
        }

        private void btnAgregarCita_Click(object sender, EventArgs e)
        {
            FormCita AgregarCita = new FormCita();
            AgregarCita.Show();
        }
    }
}
