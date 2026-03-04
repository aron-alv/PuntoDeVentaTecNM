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
    public partial class FormNomina : Form
    {

        private OperacionesBD Conexion = new OperacionesBD();
        public FormNomina(OperacionesBD conexion)
        {
            InitializeComponent();
            Conexion = conexion;
        }

        private void FormNomina_Load(object sender, EventArgs e)
        {
            Dictionary<int, string> Empleados = Conexion.ObtenerEmpleados();

            if (Empleados.Count > 0)
            {
                comboBoxEmpleados.DataSource = new BindingSource(Empleados, null);
                comboBoxEmpleados.DisplayMember = "Value";
                comboBoxEmpleados.ValueMember = "Key";


            }
            else
            {


            }

            Conexion.TodasLasNominas(dgvtablaNominas);


        }

        private void BtnGenerarNomina_Click(object sender, EventArgs e)
        {
           int idEmpleado = ((KeyValuePair<int, string>)comboBoxEmpleados.SelectedItem).Key;
           DateTime fechadehoy = DateTime.Now;
           int HorasTrabajadas = int.Parse(txtHorasTrabajadas1.Text);
            decimal PagoPorHora = decimal.Parse(txtPagoPorHora.Text);
            decimal TotalPagar = HorasTrabajadas * PagoPorHora;
           bool seregistro= Conexion.CrearNomina(idEmpleado, fechadehoy, HorasTrabajadas, TotalPagar);

            if(seregistro)
                {
                MessageBox.Show("Nómina generada exitosamente.");
                Conexion.TodasLasNominas(dgvtablaNominas);
            }
            else
            {
                MessageBox.Show("Error al generar la nómina.");
            }


        }

        private void comboBoxEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxEmpleados.SelectedItem is KeyValuePair<int, string> empleado)
            {
                int idEmpleado = empleado.Key;
               Conexion.ObtenerPagoDelClienteporHora(idEmpleado, txtPagoPorHora);
               
            }
        }



    }
}
