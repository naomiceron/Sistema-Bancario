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
    public partial class SesionContraAtm : Form
    {
        static public int numClienteVariable;
        public SesionContraAtm()
        {
            InitializeComponent();
        }

        private void inicioSesionBtn_Click(object sender, EventArgs e)
        {
            string numCuenta = usuarioSesionTxb.Text;
           int posicion = listBox1.FindString(numCuenta, -1);
             if (posicion != -1)
            {
               listBox1.SetSelected(posicion, true);
            }
            
            string nipingresado = contraSesionTxb.Text;
            if (nipingresado.Equals(nIPTextBox.Text)|| numCuenta.Equals(numClienteTextBox))
            {
                ATM.ATMForm atm = new ATM.ATMForm();
                atm.Recarga = true;
                this.Close();
                atm.Show();
                numClienteVariable = Convert.ToInt32(numCuenta);

            }
           
            else
            {
                MessageBox.Show("El usuario o la contraseña son incorrectas");
                Cajero.InicioSesion inicioSesion = new Cajero.InicioSesion();
                this.Close();
                inicioSesion.Show();
                
            }

        }

        private void SesionContraAtm_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bancoBDDataSet.ATMTabla' Puede moverla o quitarla según sea necesario.
            this.aTMTablaTableAdapter.Fill(this.bancoBDDataSet.ATMTabla);

        }
    }

      
    }

