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
using System.Windows.Controls;

namespace ClinicaVeterinaria
{
    public partial class FormMascota : Form
    {
        private int idMascota;
        private Mascota mascotaModel;
        private Action refreshDataSource;
        public FormMascota(int idMascota = 0, Action refreshDataSource = null)
        {
            InitializeComponent();
            this.idMascota = idMascota;
            this.refreshDataSource = refreshDataSource;
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

        private void guardarMascota()
        {
            Mascota mascota = new Mascota
            {
                Nombre = txtNombreMascota.Text,
                Edad = Convert.ToInt32(Math.Round(nudEdadMascota.Value, 0)),
                Especie = txtEspecieMascota.Text,
                Raza = txtRazaMascota.Text,
                IdDuenio = (int)cboDueñoMascota.SelectedItem,
            };

            MascotaController.storeMascota(mascota);
            this.refreshDataSource();
            this.Close();
        }

        private void actualizarMascota()
        {
            Mascota mascota = new Mascota
            {
                IdMascota = this.idMascota,
                Nombre = txtNombreMascota.Text,
                Edad = Convert.ToInt32(Math.Round(nudEdadMascota.Value, 0)),
                Especie = txtEspecieMascota.Text,
                Raza = txtRazaMascota.Text,
                IdDuenio = (int)cboDueñoMascota.SelectedItem,
            };

            MascotaController.updateMascota(mascota, this.idMascota);
            this.refreshDataSource();
            this.Close();
        }
        private void btnAgregarMascota_Click(object sender, EventArgs e)
        {
            if (this.idMascota <= 0)
            {
                this.guardarMascota();
            }
            else
            {
                this.actualizarMascota();
            }
        }

        private void FormMascota_Load(object sender, EventArgs e)
        {
            var duenios = DuenioController.getDuenios();
            foreach (var duenio in duenios)
            {
                cboDueñoMascota.Items.Add(duenio.IdDuenio);
            }
            if (this.idMascota > 0)
            {
                this.mascotaModel = MascotaController.getMascota(this.idMascota);
                txtNombreMascota.Text = this.mascotaModel.Nombre;
                txtEspecieMascota.Text = this.mascotaModel.Especie;
                txtRazaMascota.Text = this.mascotaModel.Raza;
                nudEdadMascota.Value = this.mascotaModel.Edad;  
                cboDueñoMascota.SelectedValue = this.mascotaModel.IdDuenio;
            }
        }
    }
}
