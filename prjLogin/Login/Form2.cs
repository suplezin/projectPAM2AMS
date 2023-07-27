using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (rbCadrastrarCliente.Checked == true)
            {
                this.Hide();
                frmCadrastoCliente cadrastoCliente = new frmCadrastoCliente();
                cadrastoCliente.Closed += (s, args) => this.Close();
                cadrastoCliente.Show();
            }
            else if (rbCadrastrarPedido.Checked == true)
            {
                this.Hide();
                frmCadPedido cadPedido = new frmCadPedido();
                cadPedido.Closed += (s, args) => this.Close();
                cadPedido.Show();
            }
            else if (rbReceberPagamento.Checked == true)
            {

            }
            else
            {
                MessageBox.Show("Nenhum item foi selecionado !", "Erro !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void rbCadrastrarPedido_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
           
        }
       
        private void btnLogoff_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }
}
