using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class ConsultaForm : Form
    {
        public ConsultaForm()
        {
            InitializeComponent();
        }

        private void regresarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aTMTablaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.aTMTablaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bancoBDDataSet);

        }

        private void ConsultaForm_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bancoBDDataSet.ATMTabla' Puede moverla o quitarla según sea necesario.
            this.aTMTablaTableAdapter.Fill(this.bancoBDDataSet.ATMTabla);
            int numCue = Convert.ToInt32(SistBanco.SesionContraAtm.numClienteVariable);
            numCuentaLbl.Text = numCue.ToString();
            SistBanco.BancoBDDataSetTableAdapters.ATMTablaTableAdapter atm = new SistBanco.BancoBDDataSetTableAdapters.ATMTablaTableAdapter();
            
        }
    }
}
