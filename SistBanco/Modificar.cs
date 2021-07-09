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
    public partial class Modificar : Form
    {
        public Modificar()
        {
            InitializeComponent();
        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gerenteTablaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gerenteTablaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bancoBDDataSet);

        }

        private void Modificar_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bancoBDDataSet.GerenteTabla' Puede moverla o quitarla según sea necesario.
            this.gerenteTablaTableAdapter.Fill(this.bancoBDDataSet.GerenteTabla);

        }

        private void apellidoMatTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void apellidoMatLabel_Click(object sender, EventArgs e)
        {

        }

        private void buscarBtn_Click(object sender, EventArgs e)
        {

        }

        private void guardarBtn_Click(object sender, EventArgs e)
        {
            int NumCliente = Convert.ToInt32(numClienteComboBox.Text);
            string Nombre = nombreTextBox.Text;
            string ApellidoPat = apellidoPatTextBox.Text;
            string ApellidoMat = apellidoMatTextBox.Text;
            string RFC = rFCTextBox.Text;
            string CURP = cURPTextBox.Text;
            string Calle = calleTextBox.Text;
            int NumExt = Int32.Parse(numExtTextBox.Text);
            int NumeroInt = Int32.Parse(numExtTextBox.Text);
            string Colonia = coloniaTextBox.Text;
            int CodigoPostal = Int32.Parse(codigoPostalTextBox.Text);
            string Municipio = municipioTextBox.Text;
            string Ciudad = ciudadTextBox.Text;
            string Estado = estadoTextBox.Text;
            string Pais = paisTextBox.Text;
            int Telefono = Convert.ToInt32(telefonoTextBox.Text);
            string Email = emailTextBox.Text;

            SistBanco.BancoBDDataSetTableAdapters.GerenteTablaTableAdapter gerente = new SistBanco.BancoBDDataSetTableAdapters.GerenteTablaTableAdapter();
            gerente.UpdateQuery(NumCliente, Nombre, ApellidoPat, ApellidoMat,
                RFC, CURP, Calle, NumExt, NumeroInt, Colonia, CodigoPostal,
                Municipio, Ciudad, Estado, Pais, Telefono, Email, NumCliente);
            MessageBox.Show("Guardado exitoso");
            this.Close();
        }
    }
}
