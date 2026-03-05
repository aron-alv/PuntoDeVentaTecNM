using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoDeVenta
{
    public partial class FormEmpleados : Form
    {
        private OperacionesBD Conexion = new OperacionesBD();
        public FormEmpleados(OperacionesBD conexion)
        {
            InitializeComponent();
            Conexion = conexion;
        }

        private void FormEmpleados_Load(object sender, EventArgs e)
        {
            Conexion.buscarTodosLosEmpleados(dgvEmpleados);
            deseleccionarfila();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BtnAgregarEmpleado_Click(object sender, EventArgs e)
        {

           

            
          
            if (dgvEmpleados.SelectedRows.Count > 0)
            {
                string nombre = txtNombreCompletodeUsuario.Text;
                string usuario = txtNombreDeUsuario.Text;
                string rol = cbmRolEmpleado.SelectedItem.ToString();
                decimal salario = Decimal.Parse(txtSueldoporHora.Text);
                int idEmpleado = Convert.ToInt32(dgvEmpleados.SelectedRows[0].Cells["ID_Empleado"].Value);
                bool resultadoModificacion = Conexion.ModificarEmpleado( nombre, usuario, rol, salario);
                if (resultadoModificacion)
                {
                    MessageBox.Show("Empleado modificado correctamente");
                    Conexion.buscarTodosLosEmpleados(dgvEmpleados);
                    
                }
             


            
            }
            else
            {
                string nombre = txtNombreCompletodeUsuario.Text;
                string usuario = txtNombreDeUsuario.Text;
                string rol = cbmRolEmpleado.SelectedItem.ToString();
                decimal salario = Decimal.Parse(txtSueldoporHora.Text);
           
                bool verificasiUsuarioExiste = Conexion.VerificarquenoexistaUsiarioAD(usuario);
              if(verificasiUsuarioExiste != true)
                {
                    MessageBox.Show("El nombre de usuario ya existe, por favor elija otro");
                    return;
                }

                bool resultado = Conexion.CrearEmpleado(nombre, usuario, rol, salario);
                if (resultado)
                {
                    MessageBox.Show("Empleado creado correctamente");
                    Conexion.buscarTodosLosEmpleados(dgvEmpleados); // Actualizar la tabla después de crear
                    deseleccionarfila();
                }
                else
                {
                    MessageBox.Show("Error al crear el empleado");
                }
            }

           


        }

        private void BtnEliminarEmpleado_Click(object sender, EventArgs e)
        {
            if (dgvEmpleados.SelectedRows.Count > 0)
            {
                int idEmpleado = Convert.ToInt32(dgvEmpleados.SelectedRows[0].Cells["ID_Empleado"].Value);
                bool resultado = Conexion.EliminarEmpleado(idEmpleado);
                if (resultado)
                {
                    MessageBox.Show("Empleado eliminado correctamente");
                    Conexion.buscarTodosLosEmpleados(dgvEmpleados); // Actualizar la tabla después de eliminar
                }
                else
                {
                    MessageBox.Show("Error al eliminar el empleado");
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un empleado para eliminar");
            }
        }

        private void dgvEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvEmpleados.Rows[e.RowIndex];

             txtNombreCompletodeUsuario.Text = row.Cells["NombreCompleto"].Value.ToString();
                txtNombreDeUsuario.Text = row.Cells["UsuarioAD"].Value.ToString();
                cbmRolEmpleado.SelectedItem = row.Cells["Rol"].Value.ToString();
                txtSueldoporHora.Text = row.Cells["SueldoPorHora"].Value.ToString();
            }
        }
        public void limpiarCampos()
        {
            txtNombreCompletodeUsuario.Text = "";
            txtNombreDeUsuario.Text = "";
            cbmRolEmpleado.SelectedIndex = -1;
            txtSueldoporHora.Text = "";
        }

        private void FormEmpleados_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            deseleccionarfila();
        }

        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void deseleccionarfila()
        {
            //deseleccionar la primera fila
            if (dgvEmpleados.Rows.Count > 0)
            {
                dgvEmpleados.ClearSelection();
            }
        }
    }
}

    

