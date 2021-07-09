using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cajero
{
    public partial class InicioSesion : Form
    {
   


        public InicioSesion()
        {
            InitializeComponent();
        }

        private void cajeroBtn_Click(object sender, EventArgs e)
        {
            SistBanco.SesionContra sesion = new SistBanco.SesionContra();
            this.Hide();
            sesion.Show();
            
        }

        private void atmBtn_Click(object sender, EventArgs e)
        {
            SistBanco.SesionContraAtm contraAtm = new SistBanco.SesionContraAtm();
            this.Hide();
            contraAtm.Show();
            
        }

        private void gerenteBtn_Click(object sender, EventArgs e)
        {
            SistBanco.SesionContra sesion = new SistBanco.SesionContra();
            this.Hide();
            sesion.Show();

        }

        private void InicioSesion_Load(object sender, EventArgs e)
        {

        }
    }
}
