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
    public partial class PreguntaForm1 : Form
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
        public PreguntaForm1()
        {
            InitializeComponent();
        }
        

        private void siguienteBtn_Click(object sender, EventArgs e)
        {
            SistBanco.OperacionesFormRecarga Op = new SistBanco.OperacionesFormRecarga();
            this.Close();
            Op.Show();
        }
        private void borrarBtn_Click(object sender, EventArgs e)
        {
            if (numeroTxtb.Text.Length > 0)
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
    }
}
