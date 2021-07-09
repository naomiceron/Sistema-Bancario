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
    public partial class AsignarForm : Form
    {
        public AsignarForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aTMTablaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.aTMTablaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bancoBDDataSet);

        }

        private void AsignarForm_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bancoBDDataSet.ATMTabla' Puede moverla o quitarla según sea necesario.
            this.aTMTablaTableAdapter.Fill(this.bancoBDDataSet.ATMTabla);

        }

        private void asignarBtn_Click(object sender, EventArgs e)
        {
            int NumCliente = Convert.ToInt32(numClienteTextBox.Text);
            int NumCuenta = Convert.ToInt32(numCuentaTextBox.Text);
            int NIP = Convert.ToInt32(nIPTextBox.Text);
            int Saldo = Convert.ToInt32(saldoTextBox.Text);
            SistBanco.BancoBDDataSetTableAdapters.ATMTablaTableAdapter cuenta = new SistBanco.BancoBDDataSetTableAdapters.ATMTablaTableAdapter();
            cuenta.Insert(NumCliente, NumCuenta, NIP, Saldo);

            MessageBox.Show("Guardado Exitoso");
            this.Close();
        }
    }
}
