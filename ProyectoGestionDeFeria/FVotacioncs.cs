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
                ConfigurarContenedorPrincipal();
                CargarVotaciones();
            }
        //==================================================================================
            private void ConfigurarContenedorPrincipal()
            {
                flowPanelVotacion.Dock = DockStyle.Fill;
                flowPanelVotacion.AutoScroll = true;
                flowPanelVotacion.FlowDirection = FlowDirection.LeftToRight;
                flowPanelVotacion.WrapContents = true;
                flowPanelVotacion.Padding = new Padding(10);

                this.Resize += (s, e) => AjustarRejillaTarjetas();
            }
        //===================================================================================
            private void AjustarRejillaTarjetas()
            {
                if (flowPanelVotacion.Controls.Count == 0) return;

                flowPanelVotacion.SuspendLayout();

                int margen = 25;
                int anchoDisponible = flowPanelVotacion.ClientSize.Width - margen;
                int columnas = anchoDisponible > 800 ? 2 : 1;
                int nuevoAncho = (anchoDisponible / columnas) - 20;

                foreach (Control ctrl in flowPanelVotacion.Controls)
                {
                    if (ctrl is Panel tarjeta)
                    {
                        tarjeta.Width = nuevoAncho;
                    }
                }

                flowPanelVotacion.ResumeLayout();
            }
        //=====================================================================================
            private void CargarVotaciones()
            {
                flowPanelVotacion.Controls.Clear();

                CN_Emprendimiento objNegocio = new CN_Emprendimiento();
                List<Emprendimiento> lista = objNegocio.ListarEmprendimientos();

                if (lista.Count == 0)
                {
                    Label lbl = new Label { Text = "No hay emprendimientos registrados.", AutoSize = true, Font = new Font("Segoe UI", 12) };
                    flowPanelVotacion.Controls.Add(lbl);
                    return;
                }

                foreach (var emp in lista)
                {
                    if (!votosSimulados.ContainsKey(emp.IdEmprendimiento))
                    {
                        Random rnd = new Random(emp.IdEmprendimiento);
                        votosSimulados.Add(emp.IdEmprendimiento, rnd.Next(5, 50));
                    }

                    Panel tarjeta = CrearTarjetaVotacion(emp);
                    flowPanelVotacion.Controls.Add(tarjeta);
                }

                AjustarRejillaTarjetas();
            }
        //======================================================================================
            private Panel CrearTarjetaVotacion(Emprendimiento emp)
            {
                // A) Contenedor de la Tarjeta
                Panel panelCard = new Panel();
                panelCard.Size = new Size(350, 220); 
                panelCard.BackColor = Color.White;
                panelCard.Margin = new Padding(10);
                panelCard.BorderStyle = BorderStyle.FixedSingle;
                panelCard.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

                // B) Título
                Label lblTitulo = new Label();
                lblTitulo.Text = "🚀 " + emp.NombreEmprendimiento;
                lblTitulo.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                lblTitulo.Location = new Point(15, 15);
                lblTitulo.AutoSize = true;
                lblTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Left;

                // C) Rubro
                Label lblRubro = new Label();
                lblRubro.Text = emp.Rubro;
                lblRubro.BackColor = Color.LightSkyBlue;
                lblRubro.ForeColor = Color.DarkBlue;
                lblRubro.AutoSize = true;
                lblRubro.Padding = new Padding(5);
                lblRubro.Font = new Font("Segoe UI", 8, FontStyle.Bold);
                lblRubro.Location = new Point(panelCard.Width - 110, 15);
                lblRubro.Anchor = AnchorStyles.Top | AnchorStyles.Right;

                // D) Sección de Votos
                Button btnVotar = new Button();
                btnVotar.Text = "👍 Votar";
                btnVotar.BackColor = Color.MediumSeaGreen;
                btnVotar.ForeColor = Color.White;
                btnVotar.FlatStyle = FlatStyle.Flat;
                btnVotar.Size = new Size(90, 32);
                btnVotar.Location = new Point(15, 55);
                btnVotar.Cursor = Cursors.Hand;
                btnVotar.Anchor = AnchorStyles.Top | AnchorStyles.Left;

                Label lblConteo = new Label();
                lblConteo.Text = $"{votosSimulados[emp.IdEmprendimiento]} votos";
                lblConteo.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                lblConteo.ForeColor = Color.CornflowerBlue;
                lblConteo.Location = new Point(115, 62);
                lblConteo.AutoSize = true;
                lblConteo.Anchor = AnchorStyles.Top | AnchorStyles.Left;

                btnVotar.Click += (s, e) => {
                    votosSimulados[emp.IdEmprendimiento]++;
                    lblConteo.Text = $"{votosSimulados[emp.IdEmprendimiento]} votos";
                    btnVotar.Enabled = false;
                    btnVotar.BackColor = Color.Gray;
                    MessageBox.Show($"¡Voto registrado para {emp.NombreEmprendimiento}!");
                };

                // E) Caja de Comentarios
                TextBox txtComentario = new TextBox();
                txtComentario.Multiline = true;
                txtComentario.Location = new Point(15, 100);
                txtComentario.Size = new Size(panelCard.Width - 40, 60);
                txtComentario.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
                txtComentario.BackColor = Color.WhiteSmoke;
                txtComentario.Font = new Font("Segoe UI", 9);

                // Placeholder simulado
                Label lblPlaceholder = new Label();
                lblPlaceholder.Text = "Escribe una sugerencia...";
                lblPlaceholder.ForeColor = Color.Gray;
                lblPlaceholder.BackColor = Color.WhiteSmoke;
                lblPlaceholder.Location = new Point(20, 105);
                lblPlaceholder.AutoSize = true;
                lblPlaceholder.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                lblPlaceholder.Click += (s, e) => txtComentario.Focus();

                txtComentario.Enter += (s, e) => lblPlaceholder.Visible = false;
                txtComentario.Leave += (s, e) => { if (txtComentario.Text == "") lblPlaceholder.Visible = true; };

                // F) Botón Comentar
                Button btnComentar = new Button();
                btnComentar.Text = "💬 Enviar";
                btnComentar.BackColor = Color.MediumSlateBlue;
                btnComentar.ForeColor = Color.White;
                btnComentar.FlatStyle = FlatStyle.Flat;
                btnComentar.Size = new Size(100, 30);
                btnComentar.Location = new Point(15, 175);
                btnComentar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;

                btnComentar.Click += (s, e) => {
                    if (!string.IsNullOrWhiteSpace(txtComentario.Text))
                    {
                        MessageBox.Show("¡Comentario enviado!");
                        txtComentario.Clear();
                        lblPlaceholder.Visible = true;
                    }
                };

                // Agregar controles
                panelCard.Controls.Add(lblTitulo);
                panelCard.Controls.Add(lblRubro);
                panelCard.Controls.Add(btnVotar);
                panelCard.Controls.Add(lblConteo);
                panelCard.Controls.Add(lblPlaceholder);
                panelCard.Controls.Add(txtComentario);
                panelCard.Controls.Add(btnComentar);
                lblPlaceholder.BringToFront();

                return panelCard;
            }
        }
    }
