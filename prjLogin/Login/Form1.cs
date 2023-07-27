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
    public partial class frmTelaLgin : Form
    {
        public frmTelaLgin()
        {
            InitializeComponent();
        }


        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if(txtUsuario.Text == "Felipe" && txtSenha.Text == "2207")
            {
                frmMenu TelaMenu = new frmMenu();
                this.Hide(); 
                TelaMenu.ShowDialog();

                /*
                this.Hide();
                frmMenu TelaMenu = new frmMenu();
                TelaMenu.Closed += (s, args) => this.Close();
                TelaMenu.Show();
                */
            }
            else
            {
                MessageBox.Show("A senha Digitada está incorreta !", "Erro !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuario.Clear();
                txtSenha.Clear();
                txtUsuario.Focus();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você Está saindo OK ! ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Application.Exit(); 
            
        }


    }
}
