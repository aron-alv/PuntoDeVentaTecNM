using PuntoDeVenta;
using System;
using System.Drawing;
using System.Windows.Forms;
using static ABARROTES.Form1;

namespace ABARROTES
{
    public partial class FormPrincipal : Form
    {
        private OperacionesBD Conexion = new OperacionesBD();
        private bool turnoTerminado = false;
        public FormPrincipal(OperacionesBD conexion)
        {
            InitializeComponent();
            PanelMostrarReportes.Visible = false;
            Conexion = conexion;
            labelUsuario.Text = UsuarioActual.Usuario;
            this.MinimumSize = new Size(this.Width, 745);
        }

        private void BtnReportes_Click(object sender, EventArgs e)
        {
            // Este solo muestra/oculta el panel, no necesita escudo
            PanelMostrarReportes.Visible = !PanelMostrarReportes.Visible;
        }

        // ==========================================
        // BOTONES DE REPORTES (Con Escudo Anti-Clics)
        // ==========================================
        private void BtnReportesVentas_Click(object sender, EventArgs e)
        {
            BtnReportesVentas.Enabled = false; Cursor.Current = Cursors.WaitCursor;
            try { AbrirFormHija(new FormReporteVentas(Conexion)); }
            finally { Cursor.Current = Cursors.Default; BtnReportesVentas.Enabled = true; }
        }

        private void BtnReportesInventario_Click(object sender, EventArgs e)
        {
            BtnReportesInventario.Enabled = false; Cursor.Current = Cursors.WaitCursor;
            try { AbrirFormHija(new FormReporteInventario(Conexion)); }
            finally { Cursor.Current = Cursors.Default; BtnReportesInventario.Enabled = true; }
        }

        private void BtnReportesSaldos_Click(object sender, EventArgs e)
        {
            BtnReportesSaldos.Enabled = false; Cursor.Current = Cursors.WaitCursor;
            try { AbrirFormHija(new FormReporteSaldos(Conexion)); }
            finally { Cursor.Current = Cursors.Default; BtnReportesSaldos.Enabled = true; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false; Cursor.Current = Cursors.WaitCursor;
            try { AbrirFormHija(new FormGenerarReportesDeProveedores(Conexion)); }
            finally { Cursor.Current = Cursors.Default; button1.Enabled = true; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false; Cursor.Current = Cursors.WaitCursor;
            try { AbrirFormHija(new FormGenerarReportesdeClientes(Conexion)); }
            finally { Cursor.Current = Cursors.Default; button2.Enabled = true; }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Enabled = false; Cursor.Current = Cursors.WaitCursor;
            try { AbrirFormHija(new ReportesVistas(Conexion)); }
            finally { Cursor.Current = Cursors.Default; button4.Enabled = true; }
        }

        // ==========================================
        // BOTONES PRINCIPALES (Con Escudo Anti-Clics)
        // ==========================================
        private void BtnProductos_Click(object sender, EventArgs e)
        {
            PanelMostrarReportes.Visible = false;
            BtnProductos.Enabled = false; Cursor.Current = Cursors.WaitCursor;
            try { AbrirFormHija(new FormProductos(Conexion)); }
            finally { Cursor.Current = Cursors.Default; BtnProductos.Enabled = true; }
        }

        private void BtnVentas_Click(object sender, EventArgs e)
        {
         
            BtnVentas.Enabled = false;
            PanelMostrarReportes.Visible = false;
            BtnVentas.Enabled = false; Cursor.Current = Cursors.WaitCursor;
            try { AbrirFormHija(new FormVentas(Conexion)); }
            finally { Cursor.Current = Cursors.Default; BtnVentas.Enabled = true; }
        }

        private void BtnInventario_Click(object sender, EventArgs e)
        {
            PanelMostrarReportes.Visible = false;
            BtnInventario.Enabled = false; Cursor.Current = Cursors.WaitCursor;
            try { AbrirFormHija(new FormInventario(Conexion)); }
            finally { Cursor.Current = Cursors.Default; BtnInventario.Enabled = true; }
        }

        private void BtnProveedores_Click(object sender, EventArgs e)
        {
            PanelMostrarReportes.Visible = false;
            BtnProveedores.Enabled = false; Cursor.Current = Cursors.WaitCursor;
            try { AbrirFormHija(new FormProveedores(Conexion)); }
            finally { Cursor.Current = Cursors.Default; BtnProveedores.Enabled = true; }
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            PanelMostrarReportes.Visible = false;
            BtnClientes.Enabled = false; Cursor.Current = Cursors.WaitCursor;
            try { AbrirFormHija(new FormClientes(Conexion)); }
            finally { Cursor.Current = Cursors.Default; BtnClientes.Enabled = true; }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false; Cursor.Current = Cursors.WaitCursor;
            try { AbrirFormHija(new FormProductosYstock(Conexion)); }
            finally { Cursor.Current = Cursors.Default; button3.Enabled = true; }
        }

        private void BtnEmpleados_Click(object sender, EventArgs e)
        {
            BtnEmpleados.Enabled = false; Cursor.Current = Cursors.WaitCursor;
            try { AbrirFormHija(new FormEmpleados(Conexion)); }
            finally { Cursor.Current = Cursors.Default; BtnEmpleados.Enabled = true; }
        }

        private void BtnNomina_Click(object sender, EventArgs e)
        {
            BtnNomina.Enabled = false; Cursor.Current = Cursors.WaitCursor;
            try { AbrirFormHija(new FormNomina(Conexion)); }
            finally { Cursor.Current = Cursors.Default; BtnNomina.Enabled = true; }
        }

        // ==========================================
        // MÉTODOS DEL SISTEMA
        // ==========================================
        private void AbrirFormHija(object formHija)
        {
            // 1. Destruimos TODOS los elementos (logos, labels, o ventanas viejas) 
            // que estén adentro del panel, no solo el primero.
            while (this.PanelContenedor.Controls.Count > 0)
            {
                var control = this.PanelContenedor.Controls[0];
                this.PanelContenedor.Controls.Remove(control);
                control.Dispose();
            }

            // 2. Preparamos la nueva ventana
            Form fh = formHija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;

            // 3. La agregamos al panel vacío
            this.PanelContenedor.Controls.Add(fh);
            this.PanelContenedor.Tag = fh;

            // 4. TRUCO VISUAL: La mandamos hasta el frente por si las dudas
            fh.BringToFront();
            fh.Show();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is FormPrincipal && form != this)
                {
                    form.Close();
                    break;
                }
            }
        }

        private void FormPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BtnCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Estás seguro que deseas cerrar tu turno?",
                                             "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                // 1. Activamos la llave maestra para que nuestro candado nos deje salir
                turnoTerminado = true;

                // 2. Le damos la orden a Windows de cerrar la sesión del usuario
                System.Diagnostics.Process.Start("shutdown", "/l");

                // 3. Cerramos nuestro programa
                Application.Exit();
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                BtnCerrarSesion_Click(this, new EventArgs());
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void PanelContenedor_Paint(object sender, PaintEventArgs e) { }
        private void labelUsuario_Click(object sender, EventArgs e) { }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && turnoTerminado == false)
            {
                e.Cancel = true; // ¡Bloqueamos el escape!
                MessageBox.Show("Modo de seguridad Kiosco activo. Use el botón de 'Cerrar Turno' para salir.",
                                "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}