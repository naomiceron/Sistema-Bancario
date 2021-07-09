using SistBanco;
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
    public partial class ATMForm : Form
    {
        Boolean recarga;
        string regresar;
        public Boolean Recarga
        {
            get
            {
                return recarga;
            }
            set
            {
                recarga = value;
            }
        }

        public string Regresar
        {
            get
            {
                return regresar;
            }
            set
            {
                regresar = value;
            }
        }

        public ATMForm()
        {
            InitializeComponent();
        }

        private void seleccionarBtn_Click(object sender, EventArgs e)
        {
            OperacionesForm Op = new OperacionesForm();
            Op.Show();
        }

        private void regresarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            if (regresar == "gerente")
            {
                Gerente.GerenteForm ger = new Gerente.GerenteForm();
                ger.Show();
            }
            else
            {
                Cajero.InicioSesion ini = new Cajero.InicioSesion();
                ini.Show();
            }
        }

        private void transferenciaBtn_Click(object sender, EventArgs e)
        {
            PreguntaForm transf = new PreguntaForm();
            transf.Label = "Número de cuenta a transferir";
            transf.Show();
            
        }

        private void recargaBtn_Click(object sender, EventArgs e)
        {
            PreguntaForm1 transf = new PreguntaForm1();
            transf.Label = "Número de teléfono";
            transf.Show();
        }

        private void consultaBtn_Click(object sender, EventArgs e)
        {
            ConsultaForm con = new ConsultaForm();
            con.Show();
        }

        private void ATMForm_Load(object sender, EventArgs e)
        {
            recargaBtn.Visible = recarga;
        }

        private void retiroBtn_Click(object sender, EventArgs e)
        {
            OperacionesForm Op = new OperacionesForm();
            Op.Show();
        }

        private void depositoBtn_Click(object sender, EventArgs e)
        {
            SistBanco.OperacionesFormDeposito ope = new SistBanco.OperacionesFormDeposito();
           
            ope.Show();
        }
    }
}
