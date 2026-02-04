using CapaDatos;
using CapaEntidades;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoGestionDeFeria
{
    public partial class FVisualizarFoto : Form
    {
        private int _id;
        private string _ruta;
        //=====================================================================================
        public FVisualizarFoto(int id, string nombre, string rutaFoto)
        {
            InitializeComponent();

            _id = id;
            _ruta = rutaFoto;
            this.Text = "Álbum y Comentarios: " + nombre;
            //_________________________________________________________________________________

            // 1. SE CARGA LA IMAGEN
            if (!string.IsNullOrEmpty(_ruta) && File.Exists(_ruta))
            {
                pBoxFotoGrande.ImageLocation = _ruta;
                pBoxFotoGrande.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                pBoxFotoGrande.BackColor = Color.MistyRose;
            }

            // 2. SE CARGAN LOS COMENTARIOS
            CargarComentarios();
        }
        //=====================================================================================
        private void CargarComentarios()
        {
            lstComentarios.Items.Clear();
            lstComentarios.Items.Add($"[Sistema] Bienvenido a la galería.");

            CN_Comentario objNegocio = new CN_Comentario();

            List<string> lista = objNegocio.ListarComentariosPorEmprendimiento(_id);

            foreach (string comentario in lista)
            {
                lstComentarios.Items.Add(comentario);
            }
        }
        //=====================================================================================
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNuevoComentario.Text)) return;

            CN_Comentario objNegocio = new CN_Comentario();
            string mensaje = string.Empty;

            bool exito = objNegocio.RegistrarComentario(_id, txtNuevoComentario.Text, out mensaje);

            if (exito)
            {
                CargarComentarios();
                txtNuevoComentario.Clear();
                lstComentarios.TopIndex = lstComentarios.Items.Count - 1;
            }
            else
            {
                MessageBox.Show("No se pudo enviar: " + mensaje);
            }
        }
    }
    }
    

