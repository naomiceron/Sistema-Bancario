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
    public partial class DarDeAlta : Form
    {
        public DarDeAlta()
        {
            InitializeComponent();
        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guardarBtn_Click(object sender, EventArgs e)
        {
            int NumCliente = Convert.ToInt32(numClienteTxb.Text);
            string Nombre = nombreTxB.Text;
            string ApellidoPat = pApellidoTxB.Text;
            string ApellidoMat = sApellidoTxB.Text;
            string RFC = rfcTxB.Text;
            string CURP = curpTxB.Text;
            string Calle = calleTxB.Text;
            int NumExt = Int32.Parse(numeroETxB.Text);
            int NumeroInt = Int32.Parse(numeroITxB.Text);
            string Colonia = coloniaTxB.Text;
            int CodigoPostal = Int32.Parse(cpTxB.Text);
            string Municipio = municipioTxB.Text;
            string Ciudad = ciudadTxB.Text;
            string Estado = estadoTxB.Text;
            string Pais = paisTxB.Text;
            int Telefono = Convert.ToInt32(telefonoTxB.Text);
            string Email = correoTxB.Text;

            SistBanco.BancoBDDataSetTableAdapters.GerenteTablaTableAdapter gerente = new SistBanco.BancoBDDataSetTableAdapters.GerenteTablaTableAdapter();
            gerente.Insert(NumCliente, Nombre, ApellidoPat, ApellidoMat, RFC, CURP, Calle, NumExt, NumeroInt, Colonia, CodigoPostal, Municipio, Ciudad, Estado, Pais, Telefono, Email);

            MessageBox.Show("Guardado Exitoso");
            this.Close();
            
        }
    }
}
