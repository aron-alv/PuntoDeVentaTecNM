
using PuntoDeVenta;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;


namespace ABARROTES
{
    public partial class FormVentas : Form
    {
        private OperacionesBD Conexion = new OperacionesBD();
        private List<Tuple<int, string, decimal>> productos;
        private bool turnoTerminado = false;
        public FormVentas(OperacionesBD conexion)
        {
        
            InitializeComponent();
        
            Conexion = conexion;
            this.KeyPreview = true;
            //maximiar la ventana al abrir
            //this.WindowState = FormWindowState.Maximized;
            //oculta la barra de tareas
            //this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;

        }
        private void CargarClientes()
        {
          
            Dictionary<int, string> clientes = Conexion.ObtenerClientes();


            if (clientes.Count > 0)
            {

            }
            else
            {

            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter && this.ActiveControl == txtIDVenta)
            {
                BuscarIDVenta_Click(this, new EventArgs());

                return true;
            }
            if (keyData == Keys.F5)
            {
                BtnRealizarVenta_Click(this, new EventArgs());
                return true;
            }
            if (keyData == Keys.Enter && this.ActiveControl == txtCantidad)
            {
                BtnAgregarATabla_Click(this, new EventArgs());
                comboBoxProductos.Focus();
                return true;
            }

            //si aplasta F1 se cierra el turno
            if (keyData == Keys.F1)
            {
                btnCerrarTurno_Click(this, new EventArgs());
                return true;
            }

                return base.ProcessCmdKey(ref msg, keyData);
        }

        private void BtnAgregarATabla_Click(object sender, EventArgs e)
        {
            if (comboBoxProductos.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un producto.");
                return;
            }
            if (string.IsNullOrEmpty(txtCantidad.Text))
            {
                MessageBox.Show("Ingrese la cantidad del producto.");
                return;
            }
            var selectedProduct = comboBoxProductos.SelectedItem as dynamic;
            int productId = selectedProduct.Id;
            var producto = productos.Find(p => p.Item1 == productId);

            if (producto != null)
            {
                string nombre = producto.Item2;
                decimal precio = producto.Item3;
                decimal cantidad = decimal.Parse(txtCantidad.Text);
                decimal importe = precio * cantidad;
                //si el producto ya esta en la tabla, solo se actualiza la cantidad
                foreach (DataGridViewRow row in dataGridViewProductos.Rows)
                {
                    if (Convert.ToInt32(row.Cells[0].Value) == productId)
                    {
                        decimal cantidadActual = Convert.ToDecimal(row.Cells[2].Value);
                        decimal precioActual = Convert.ToDecimal(row.Cells[3].Value);
                        decimal importeActual = cantidadActual * precioActual;
                        cantidad += cantidadActual;
                        importe = importeActual + importe;
                        dataGridViewProductos.Rows.Remove(row);
                        break;
                    }
                }
                dataGridViewProductos.Rows.Add(productId, nombre, cantidad, precio, importe);
            }
            UpdateTotals();
            txtCantidad.Text = "";
            comboBoxProductos.SelectedIndex = -1;
            tablaFolios.Visible = false;
        }

        private void dataGridViewProductos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.RowIndex >= 0 && e.RowIndex < dataGridViewProductos.Rows.Count)
            {
                var row = dataGridViewProductos.Rows[e.RowIndex];
                decimal cantidad = Convert.ToDecimal(row.Cells[2].Value);
                decimal precio = Convert.ToDecimal(row.Cells[3].Value);
                decimal importe = cantidad * precio;
                row.Cells[4].Value = importe;


                UpdateTotals();
            }
        }
        private void UpdateTotals()
        {
            decimal subtotal = 0;
            foreach (DataGridViewRow r in dataGridViewProductos.Rows)
            {
                if (r.Cells[4].Value != null)
                {
                    subtotal += Convert.ToDecimal(r.Cells[4].Value);
                }
            }
            decimal iva = subtotal * 0.16m;
            decimal total = subtotal + iva;

            // actualizar los valores en los TextBoxes
            textBoxSubtotal.Text = subtotal.ToString("C");
            textBoxIVA.Text = iva.ToString("C");
            textBoxTotal.Text = total.ToString("C");
        }

        private void BtnRealizarVenta_Click(object sender, EventArgs e)
        {
            decimal subtotal;
            if (!decimal.TryParse(textBoxSubtotal.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out subtotal))
            {
                MessageBox.Show("ingrese los Campos faltantes.");
                return;
            }

            decimal iva = decimal.Parse(textBoxIVA.Text, System.Globalization.NumberStyles.Currency);
            decimal total = decimal.Parse(textBoxTotal.Text, System.Globalization.NumberStyles.Currency);
            DateTime fecha = DateTime.Now;
            string metodoPago = CbmMetododePago.Text;


         




            // Obtener los detalles de la venta desde la tabla
            List<Tuple<int, decimal, decimal>> detallesVenta = new List<Tuple<int, decimal, decimal>>();
            foreach (DataGridViewRow row in dataGridViewProductos.Rows)
            {
                if (row.Cells["ID"].Value != null && row.Cells["Cantidad"].Value != null && row.Cells["Importe"].Value != null)
                {
                    int idProducto = Convert.ToInt32(row.Cells["ID"].Value);
                    decimal cantidad = Convert.ToDecimal(row.Cells["Cantidad"].Value);
                    decimal precio = Convert.ToDecimal(row.Cells["Importe"].Value);
                    detallesVenta.Add(new Tuple<int, decimal, decimal>(idProducto, cantidad, precio));
                }
            }


            try
            {
                // registrar la venta
                bool ventaRegistrada = Conexion.RegistrarVenta(fecha, subtotal, iva, total, metodoPago, detallesVenta);

                if (ventaRegistrada)
                {
                    MessageBox.Show("Venta realizada con exito.");
                    dataGridViewProductos.Rows.Clear();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Error al realizar la venta.");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error al realizar la venta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void LimpiarCampos()
        {
            textBoxSubtotal.Text = "-";
            textBoxIVA.Text = "-";
            textBoxTotal.Text = "-";
            txtCantidad.Text = "";
            comboBoxProductos.SelectedIndex = -1;
        }

        private void eLIMINARPRODUCTOToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (dataGridViewProductos.SelectedRows.Count > 0)
            {
                dataGridViewProductos.Rows.RemoveAt(dataGridViewProductos.SelectedRows[0].Index);
                UpdateTotals();
            }
        }

        private void dataGridViewProductos_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (dataGridViewProductos.SelectedRows.Count > 0)
                {
                    dataGridViewProductos.ContextMenuStrip = SubMenu;
                }
            }
        }

        private void dataGridViewProductos_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void BuscarIDVenta_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtIDVenta.Text))
            {
                FormVentas_Load(this, new EventArgs());
            }
            else
            {
                int idVenta = int.Parse(txtIDVenta.Text);

                try
                {
                    Conexion.BuscarIDVenta(idVenta, tablaFolios);
                    tablaFolios.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrio un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void BtnDashBoards_Click(object sender, EventArgs e)
        {
            ReportesVistas reportesVistas = new ReportesVistas(Conexion);
            reportesVistas.Show();

        }

        private void btnCerrarTurno_Click(object sender, EventArgs e)
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

        private void FormVentas_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && turnoTerminado == false)
            {
                e.Cancel = true; // ¡Bloqueamos el escape!
                MessageBox.Show("Modo de seguridad Kiosco activo. Use el botón de 'Cerrar Turno' para salir.",
                                "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void tablaFolios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormVentas_Shown(object sender, EventArgs e)
        {

            // Obliga a pintar la ventana al instante
            Application.DoEvents();

            // Ponemos el relojito
            Cursor = Cursors.WaitCursor;

            try
            {
                comboBoxProductos.Items.Clear();
                int proximoIDVenta = Conexion.ObtenerProximoIDVenta();
                txtIDVenta.Text = proximoIDVenta.ToString();

                // MAGIA PURA: 1 solo viaje a la base de datos para traer todo
                productos = Conexion.ObtenerTodosLosProductosConPrecio();

                // Llenamos el ComboBox rapidísimo con los datos que ya tenemos en memoria
                foreach (var prod in productos)
                {
                    comboBoxProductos.Items.Add(new { Id = prod.Item1, Nombre = prod.Item2 });
                }

                // Prevenimos error si CbmMetododePago está vacío
                if (CbmMetododePago.Items.Count > 0)
                {
                    CbmMetododePago.SelectedIndex = 0;
                }

                comboBoxProductos.DisplayMember = "Nombre";
                comboBoxProductos.ValueMember = "Id";

                CargarClientes();

                comboBoxProductos.TabIndex = 1;
                txtCantidad.TabIndex = 2;
                tablaFolios.Visible = false;

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
            finally
            {
                // Regresamos el cursor a la normalidad
                Cursor = Cursors.Default;
            }
        }

        private void FormVentas_Load(object sender, EventArgs e)
        {

        }
    }

}

