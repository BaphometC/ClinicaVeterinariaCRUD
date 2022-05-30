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

namespace ClinicaVeterinaria
{
    public partial class ViewMascotas : Form
    {
        
        public ViewMascotas()
        {
            InitializeComponent();
        }

        
        private void VistaPacientes_Load(object sender, EventArgs e)
        {
            var Mascotas = MascotaController.getMascota();
            dgvListaClientes.DataSource = Mascotas;
            dgvListaClientes.Columns["Duenio"].Visible = false;
            dgvListaClientes.Columns["Cita"].Visible = false;
            
            
        }

        private void btnAgregarMascotaCita_Click(object sender, EventArgs e)
        {
            FormMascota AgregarMascota = new FormMascota();
            AgregarMascota.Show();
        }

        private void btnAgregarDueñoMascota_Click(object sender, EventArgs e)
        {
            FormDuenio AgregarDuenio = new FormDuenio();
            AgregarDuenio.Show();
        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {

        }
    }
}
