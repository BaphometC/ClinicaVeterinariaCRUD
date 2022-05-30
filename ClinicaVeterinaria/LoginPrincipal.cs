using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidad;
using Negocio;

namespace ClinicaVeterinaria
{
    public partial class LoginPrincipal : Form
    {
        public LoginPrincipal()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try {
                Recepcionista rece = new Recepcionista
                {
                    IdRecepcionista = Int32.Parse(txtId.Text),
                    Contrasenia = txtContra.Text
                };

                ViewRecepcion VistaInicial = new ViewRecepcion();
                if (LoginController.validate(rece))
                {
                    VistaInicial.Show();
                }
                else
                {
                    MessageBox.Show("Credenciales NO validas");
                }

            }
            catch
            {
                MessageBox.Show("Credenciales NO validas");
            }


        }

        private void btnLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.btnLogin_Click(this,EventArgs.Empty);
            }
        }
    }
}
