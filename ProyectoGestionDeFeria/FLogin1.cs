using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace ProyectoGestionDeFeria
{
    public partial class FLogin1 : Form
    {
        public FLogin1()
        {
            InitializeComponent();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtClave.Text))
            {
                MessageBox.Show("Por favor ingrese usuario y contraseña.");
                return;
            }

            CN_Usuario objUsuario = new CN_Usuario();

            bool esValido = objUsuario.ValidarUsuario(txtUsuario.Text, txtClave.Text);

            if (esValido)
            {
             
                Form1 formAdmin = new Form1();
                formAdmin.Show();

                this.Hide(); 
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas.\nIntente: admin / 123456", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //===================================================================================
        private void btnEstudiante_Click(object sender, EventArgs e)
        {
            FModuloEstudiante formEstudiante = new FModuloEstudiante();
            formEstudiante.Show();

            this.Hide();
        }
        //===================================================================================
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
