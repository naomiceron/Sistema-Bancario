using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerente
{
    public partial class GerenteForm : Form
    {
        public GerenteForm()
        {
            InitializeComponent();
        }

        private void GerenteForm_Load(object sender, EventArgs e)
        {

        }

        private void altaCuentaBtn_Click(object sender, EventArgs e)
        {
            DarDeAltaCuentaForm darAlta = new DarDeAltaCuentaForm();
            darAlta.Show();
        }

        private void modificarCuentaBtn_Click(object sender, EventArgs e)
        {
            ModificarCuentaForm modificarCuenta = new ModificarCuentaForm();
            modificarCuenta.Show();
        }

        private void buscarCuentaBtn_Click(object sender, EventArgs e)
        {
            BuscarCuentaForm buscarCuenta = new BuscarCuentaForm();
            buscarCuenta.Show();
        }

        private void asignarCuentaBtn_Click(object sender, EventArgs e)
        {
            AsignarForm asignarCuenta = new AsignarForm();
            asignarCuenta.Show();
        }

        private void regresarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Cajero.InicioSesion ini = new Cajero.InicioSesion();
            ini.Show();
        }

        private void operacionesBtn_Click(object sender, EventArgs e)
        {
            ATM.ATMForm atm = new ATM.ATMForm();
            atm.Recarga = false;
            atm.Regresar = "gerente";
            this.Close();
            atm.Show();
        }

        private void altaClienteBtn_Click(object sender, EventArgs e)
        {
            Cajero.DarDeAlta deAlta = new Cajero.DarDeAlta();
            deAlta.Show();
        }

        private void modificarClienteBtn_Click(object sender, EventArgs e)
        {
            Cajero.Modificar mod = new Cajero.Modificar();
            mod.Show();
        }

        private void buscarClienteBtn_Click(object sender, EventArgs e)
        {
            Cajero.Buscar bus = new Cajero.Buscar();
            bus.Show();
        }
    }
}
