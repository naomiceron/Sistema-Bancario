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
    public partial class ModificarCuentaForm : Form
    {
        public ModificarCuentaForm()
        {
            InitializeComponent();
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

        private void ModificarCuentaForm_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bancoBDDataSet.ATMTabla' Puede moverla o quitarla según sea necesario.
            this.aTMTablaTableAdapter.Fill(this.bancoBDDataSet.ATMTabla);

        }

        private void aceptarBtn_Click(object sender, EventArgs e)
        {
            int numCuenta = Convert.ToInt32(SistBanco.SesionContraAtm.numClienteVariable);
            SistBanco.BancoBDDataSetTableAdapters.ATMTablaTableAdapter atm = new SistBanco.BancoBDDataSetTableAdapters.ATMTablaTableAdapter();
            int nuevoNip = Convert.ToInt32(nuevoNipTxb.Text);
            MessageBox.Show("Su NIP ha sido actualizado");
            atm.UpdateQuery1(nuevoNip, numCuenta);
            this.Close();
        }
    }
}
