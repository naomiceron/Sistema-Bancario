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
    public partial class Buscar : Form
    {
        public Buscar()
        {
            InitializeComponent();
        }

        private void regresarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void Buscar_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bancoBDDataSet.GerenteTabla' Puede moverla o quitarla según sea necesario.
            this.gerenteTablaTableAdapter.Fill(this.bancoBDDataSet.GerenteTabla);

        }

        private void nombreLabel_Click(object sender, EventArgs e)
        {

        }

        private void numExtLabel1_Click(object sender, EventArgs e)
        {

        }

        private void numExtLabel_Click(object sender, EventArgs e)
        {

        }

        private void codigoPostalLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
