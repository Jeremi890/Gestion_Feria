using CapaEntidades;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProyectoGestionDeFeria
{
    public partial class FVisualizarFoto : Form
    {
        private int _id;
        private string _ruta;
        //=====================================================================================
        public FVisualizarFoto(int id, string nombre, string rutaFoto)
        {
            InitializeComponent(); // Dibuja la ventana y los controles vacíos

            _id = id;
            _ruta = rutaFoto;
            this.Text = "Álbum y Comentarios: " + nombre;
            //_________________________________________________________________________________

            // 1. CARGAMOS IMAGEN
            if (!string.IsNullOrEmpty(_ruta) && File.Exists(_ruta))
            {
                pBoxFotoGrande.ImageLocation = _ruta;
                pBoxFotoGrande.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                pBoxFotoGrande.BackColor = Color.MistyRose;
            }

            // 2. CARGAMOS COMENTARIOS
            CargarComentarios();
        }
        //=====================================================================================
        private void CargarComentarios()
        {
            lstComentarios.Items.Clear();
            lstComentarios.Items.Add($"[Sistema] Bienvenido a la galería.");
        }
        //=====================================================================================
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNuevoComentario.Text)) return;

            lstComentarios.Items.Add($"[Tú]: {txtNuevoComentario.Text}");
            txtNuevoComentario.Clear();
            lstComentarios.TopIndex = lstComentarios.Items.Count - 1;
        }
    }
    }
    

