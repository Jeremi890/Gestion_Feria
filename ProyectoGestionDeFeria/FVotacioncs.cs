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

namespace ProyectoGestionDeFeria
{
    public partial class FVotacioncs : Form
    {
        private Dictionary<int, int> votosSimulados = new Dictionary<int, int>();
        public FVotacioncs()
        {
            InitializeComponent();
            CargarVotaciones();
        }
        //=====================================================================================
        private void CargarVotaciones()
        {
            flowPanelVotacion.Controls.Clear();

            CN_Emprendimiento objNegocio = new CN_Emprendimiento();
            List<Emprendimiento> lista = objNegocio.ListarEmprendimientos();

            // Verifica si hay datos
            if (lista.Count == 0)
            {
                Label lbl = new Label { Text = "No hay emprendimientos registrados para votar.", AutoSize = true, Font = new Font("Segoe UI", 12) };
                flowPanelVotacion.Controls.Add(lbl);
                return;
            }

            foreach (var emp in lista)
            {
                if (!votosSimulados.ContainsKey(emp.IdEmprendimiento))
                {
                    // Generamos un número aleatorio entre 5 y 50 solo como simulación
                    Random rnd = new Random(emp.IdEmprendimiento); 
                    votosSimulados.Add(emp.IdEmprendimiento, rnd.Next(5, 50));
                }

                Panel tarjeta = CrearTarjetaVotacion(emp);
                flowPanelVotacion.Controls.Add(tarjeta);
            }
        }
        //=====================================================================================
        private Panel CrearTarjetaVotacion(Emprendimiento emp)
        {
            // A) Contenedor 
            Panel panelCard = new Panel();
            panelCard.Size = new Size(750, 200); // Ancho: 750, Alto: 200
            panelCard.BackColor = Color.White;
            panelCard.Margin = new Padding(10, 10, 10, 20); // Margen inferior amplio
            ControlPaint.DrawBorder(panelCard.CreateGraphics(), panelCard.ClientRectangle, Color.CornflowerBlue, ButtonBorderStyle.Solid);
            panelCard.BorderStyle = BorderStyle.FixedSingle;

            // B) Cabecera: Título y Rubro
            Label lblTitulo = new Label();
            lblTitulo.Text = "Build: " + emp.NombreEmprendimiento; // Icono simulado
            lblTitulo.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            lblTitulo.Location = new Point(20, 15);
            lblTitulo.AutoSize = true;

            Label lblRubro = new Label();
            lblRubro.Text = emp.Rubro;
            lblRubro.BackColor = Color.LightSkyBlue; // Fondo suave
            lblRubro.ForeColor = Color.DarkBlue;
            lblRubro.AutoSize = true;
            lblRubro.Padding = new Padding(5);
            lblRubro.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            lblRubro.Location = new Point(650, 15); // A la derecha

            // C) Sección de Votos
            Button btnVotar = new Button();
            btnVotar.Text = "👍 Votar";
            btnVotar.BackColor = Color.MediumSeaGreen;
            btnVotar.ForeColor = Color.White;
            btnVotar.FlatStyle = FlatStyle.Flat;
            btnVotar.FlatAppearance.BorderSize = 0;
            btnVotar.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btnVotar.Size = new Size(100, 35);
            btnVotar.Location = new Point(20, 55);
            btnVotar.Cursor = Cursors.Hand;

            Label lblConteo = new Label();
            lblConteo.Text = $"{votosSimulados[emp.IdEmprendimiento]} votos";
            lblConteo.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            lblConteo.ForeColor = Color.CornflowerBlue;
            lblConteo.Location = new Point(130, 62); 
            lblConteo.AutoSize = true;

            // EVENTO DE LA VOTACIÓN
            btnVotar.Click += (s, e) => {
                votosSimulados[emp.IdEmprendimiento]++; 
                lblConteo.Text = $"{votosSimulados[emp.IdEmprendimiento]} votos"; 
                MessageBox.Show($"¡Gracias por tu voto a {emp.NombreEmprendimiento}!");
                btnVotar.Enabled = false;
                btnVotar.BackColor = Color.Gray;
            };

            // D) Caja de Comentarios (TextField grande)
            TextBox txtComentario = new TextBox();
            txtComentario.Multiline = true;
            txtComentario.Size = new Size(700, 50); 
            txtComentario.Location = new Point(20, 100);
            txtComentario.BorderStyle = BorderStyle.FixedSingle;
            txtComentario.BackColor = Color.WhiteSmoke;
            txtComentario.Font = new Font("Segoe UI", 10);
            txtComentario.Text = ""; 

            // Placeholder visual
            Label lblPlaceholder = new Label();
            lblPlaceholder.Text = "Deja tu comentario o sugerencia...";
            lblPlaceholder.ForeColor = Color.Gray;
            lblPlaceholder.BackColor = Color.WhiteSmoke;
            lblPlaceholder.Location = new Point(25, 105);
            lblPlaceholder.AutoSize = true;
            lblPlaceholder.Click += (s, e) => { txtComentario.Focus(); }; // Si clickean label, va al txt

            // Evento para ocultar el placeholder
            txtComentario.Enter += (s, e) => { lblPlaceholder.Visible = false; };
            txtComentario.Leave += (s, e) => { if (txtComentario.Text == "") lblPlaceholder.Visible = true; };


            // E) Botón Comentar
            Button btnComentar = new Button();
            btnComentar.Text = "💬 Comentar";
            btnComentar.BackColor = Color.MediumSlateBlue; // Morado como la referencia
            btnComentar.ForeColor = Color.White;
            btnComentar.FlatStyle = FlatStyle.Flat;
            btnComentar.Size = new Size(120, 30);
            btnComentar.Location = new Point(20, 160); // Debajo del texto

            // EVENTO DE COMENTAR
            btnComentar.Click += (s, e) => {
                if (string.IsNullOrWhiteSpace(txtComentario.Text))
                {
                    MessageBox.Show("Escribe algo antes de enviar.");
                    return;
                }
                MessageBox.Show("¡Tu comentario ha sido enviado al emprendedor!");
                txtComentario.Clear();
                lblPlaceholder.Visible = true;
            };

            panelCard.Controls.Add(lblTitulo);
            panelCard.Controls.Add(lblRubro);
            panelCard.Controls.Add(btnVotar);
            panelCard.Controls.Add(lblConteo);
            panelCard.Controls.Add(txtComentario);
            panelCard.Controls.Add(lblPlaceholder);
            lblPlaceholder.BringToFront();

            panelCard.Controls.Add(btnComentar);

            return panelCard;
        }
    }
}
