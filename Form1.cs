using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Login_e_Senha_08_05_24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bntCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bntOK_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "Admin" && textBoxSenha.Text == "123456")
            {
                MessageBox.Show("Bem Vindo ao Sistema!", "Acesso ao Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Acesso Negado!", "Acesso Negado!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

