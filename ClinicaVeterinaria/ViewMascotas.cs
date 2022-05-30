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

        private void refreshDatasource()
        {
            var Mascotas = MascotaController.getMascotas();
            dgvListaClientes.DataSource = Mascotas;
            dgvListaClientes.Columns["Duenio"].Visible = false;
            dgvListaClientes.Columns["Cita"].Visible = false;
        }
        private void VistaPacientes_Load(object sender, EventArgs e)
        {
            this.refreshDatasource();
        }

        private void btnAgregarMascotaCita_Click(object sender, EventArgs e)
        {
            Action refreshAction = refreshDatasource;
            FormMascota AgregarMascota = new FormMascota(0, refreshAction);
            AgregarMascota.Show();
        }

        private void btnAgregarDueñoMascota_Click(object sender, EventArgs e)
        {
            FormDuenio AgregarDuenio = new FormDuenio();
            AgregarDuenio.Show();
        }

        private void btnEditarMascota_Click(object sender, EventArgs e)
        {
            
            int rowIndex = dgvListaClientes.CurrentCell.RowIndex;
            int id = Int32.Parse(dgvListaClientes.Rows[rowIndex]
                .Cells[0].Value
                .ToString());

            Action refreshAction = refreshDatasource;

            FormMascota EditarMascota = new FormMascota(id, refreshAction);
            EditarMascota.Show();        
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            int rowIndex = dgvListaClientes.CurrentCell.RowIndex;
            int id = Int32.Parse(dgvListaClientes.Rows[rowIndex]
                .Cells[0].Value
                .ToString());

            MascotaController.deleteMascota(id);
            this.refreshDatasource();
        }
    }
}
