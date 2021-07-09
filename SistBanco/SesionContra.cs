using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistBanco
{
    public partial class SesionContra : Form
    {
        public SesionContra()
        {
            InitializeComponent();
        }

        private void SesionContra_Load(object sender, EventArgs e)
        {

        }

        private void inicioSesionBtn_Click(object sender, EventArgs e)
        {
            if (usuarioSesionTxb.Text == "gerente" && contraSesionTxb.Text=="contraseña123")
            {
                Gerente.GerenteForm gerente = new Gerente.GerenteForm();
                this.Hide();
                gerente.Show();
            }else if(usuarioSesionTxb.Text == "cajero" && contraSesionTxb.Text == "contraseña321")
            {
                ATM.ATMForm atm = new ATM.ATMForm();
                atm.Recarga = false;
                this.Hide();
                atm.Show();

            }
            else
            {
                System.Windows.Forms.MessageBox.Show("El usuario o la contraseña son incorrectas");
                Cajero.InicioSesion inicioSesion = new Cajero.InicioSesion();
                this.Hide();
                inicioSesion.Show();

            }
        }

        private void usuarioSesionTxb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
