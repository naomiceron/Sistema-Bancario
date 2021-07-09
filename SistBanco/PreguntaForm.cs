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
    public partial class PreguntaForm : Form
    {
        string label;
        Boolean banderaOperador;
        

        public string Label
        {
            get
            {
                return label;
            }
            set
            {
                label = value;
            }
        }

        public PreguntaForm()
        { 

            InitializeComponent();
        }

        private void PreguntaForm_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bancoBDDataSet.ATMTabla' Puede moverla o quitarla según sea necesario.
            this.aTMTablaTableAdapter.Fill(this.bancoBDDataSet.ATMTabla);
            // TODO: esta línea de código carga datos en la tabla 'bancoBDDataSet.ATMTabla' Puede moverla o quitarla según sea necesario.
            this.aTMTablaTableAdapter.Fill(this.bancoBDDataSet.ATMTabla);
            preguntaLbl.Text = label;
        }

        private void siguienteBtn_Click(object sender, EventArgs e)
        {
            string numCuenta = numeroTxtb.Text;
            int posicion = listBox1.FindString(numCuenta, -1);
            if (posicion != -1)
            {
                listBox1.SetSelected(posicion, true);
            }

            if (numCuenta.Equals(numCuentaLabel1.Text))
            {
                SistBanco.OperacionFormTransferencia Op = new SistBanco.OperacionFormTransferencia(saldoLabel1.Text,numCuentaLabel1.Text);
                this.Close();
                Op.Show();
            }
            else
            {
                MessageBox.Show("El número a transferir es incorrecto");
                this.Close();
            }
            
            
        }

        private void borrarBtn_Click(object sender, EventArgs e)
        {
            if(numeroTxtb.Text.Length > 0)
            {
                numeroTxtb.Text = numeroTxtb.Text.Remove(numeroTxtb.Text.Length - 1);
            }
        }

        private void numero_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;

            if (banderaOperador == true)
            {
                numeroTxtb.Text = boton.Text;
                banderaOperador = false;
            }
            else
            {
                numeroTxtb.Text = numeroTxtb.Text + boton.Text;
            }

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
    }
}
