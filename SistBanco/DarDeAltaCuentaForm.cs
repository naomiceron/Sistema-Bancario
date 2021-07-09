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
    public partial class DarDeAltaCuentaForm : Form
    {
        public DarDeAltaCuentaForm()
        {
            InitializeComponent();
        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aceptarBtn_Click(object sender, EventArgs e)
        {
            int NumCliente = Convert.ToInt32(numeroClienteTxb.Text);
            int NumCuenta = Convert.ToInt32(numeroCuentaTxb.Text);
            int NIP = Convert.ToInt32(nipTxb.Text);
            int Saldo = Convert.ToInt32(saldoTxb.Text);
            SistBanco.BancoBDDataSetTableAdapters.ATMTablaTableAdapter cuenta = new SistBanco.BancoBDDataSetTableAdapters.ATMTablaTableAdapter();
            cuenta.Insert(NumCliente, NumCuenta, NIP, Saldo);

            MessageBox.Show("Guardado Exitoso");
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void DarDeAltaCuentaForm_Load(object sender, EventArgs e)
        {

        }
    }
}
