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
    public partial class OperacionFormTransferencia : Form
    {
        Boolean banderaOperador = true;
        string saldo,numCuenta2;
        public OperacionFormTransferencia(string saldo,string cuenta)
        {
            this.saldo = saldo;
            this.numCuenta2 = cuenta;
            InitializeComponent();
        }

        private void numero_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;

            if (banderaOperador == true)
            {
                pantallaNumTxtb.Text = boton.Text;
                banderaOperador = false;
            }
            else
            {
                pantallaNumTxtb.Text = pantallaNumTxtb.Text + boton.Text;
            }

        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void borrarBtn_Click(object sender, EventArgs e)
        {
            pantallaNumTxtb.Clear();
        }
        private void aceptarBtn_Click(object sender, EventArgs e)
        {
            int cantidad = Convert.ToInt32(pantallaNumTxtb.Text);
            int numCue = Convert.ToInt32(SistBanco.SesionContraAtm.numClienteVariable);

            SistBanco.BancoBDDataSetTableAdapters.ATMTablaTableAdapter atm = new SistBanco.BancoBDDataSetTableAdapters.ATMTablaTableAdapter();
            int nuevoSa = Convert.ToInt32(saldoTextBox1.Text) - cantidad;
            MessageBox.Show("Su nuevo saldo es: " + nuevoSa);
            atm.UpdateQuery(nuevoSa, numCue);
            int saldo2 = Convert.ToInt32(saldo + cantidad);

            atm.UpdateQuery(saldo2, Convert.ToInt32(numCuenta2));
            this.Close();
        }
        private void aTMTablaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.aTMTablaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bancoBDDataSet);
        }

        private void aTMTablaBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.aTMTablaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bancoBDDataSet);

        }

        private void OperacionFormTransferencia_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bancoBDDataSet.ATMTabla' Puede moverla o quitarla según sea necesario.
            this.aTMTablaTableAdapter.Fill(this.bancoBDDataSet.ATMTabla);

        }
    }
}
