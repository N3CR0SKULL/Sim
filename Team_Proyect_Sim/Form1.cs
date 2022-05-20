using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team_Proyect_Sim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdIntroducir_Click(object sender, EventArgs e)
        {
            //Declaracion
            float Xn, X0;
            int A, C, M;

            //Captura
            try
            {
                X0 = System.Single.Parse(txtSemilla.Text);
                A = System.Int32.Parse(txtC_M.Text);
                C = System.Int32.Parse(txtC_A.Text);
                M = System.Int32.Parse(txtMod.Text);
            }

            catch (System.FormatException)
            {
                MessageBox.Show("Error \nLos datos introducidos no son validos. \n Porfavor vuelva a intentarlo", 
                    "Datos Erroneos", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                txtC_A.Clear();
                txtC_M.Clear();
                txtMod.Clear();
                txtSemilla.Clear();
            }
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdClean_Click(object sender, EventArgs e)
        {
            //Limpiar
            txtC_A.Clear();
            txtC_M.Clear();
            txtMod.Clear();
            txtSemilla.Clear();

            //Habilitar
            txtC_A.ReadOnly = true;
            txtC_M.ReadOnly = true;
            txtMod.ReadOnly = true;
            txtSemilla.ReadOnly = true;
        }

        private void txtC_M_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtC_M_AcceptsTabChanged(object sender, EventArgs e)
        {
        }
    }
}
