using PuntoDeVenta;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace ABARROTES
{
    public partial class FormReporteVentas : Form
    {
        private OperacionesBD Conexion = new OperacionesBD();
        public FormReporteVentas(OperacionesBD conexion)
        {
            InitializeComponent();
            Conexion = conexion;
        }

       


        private void FormReporteVentas_Load(object sender, System.EventArgs e)
        {
           
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DateTime? fechaInicio = null;
            DateTime? fechaFin = null;
            int? idCliente = null;

            if (checkBoxFechaInicio.Checked)
            {
                fechaInicio = dateTimePickerInicio.Value;
            }


            if (checkBoxFechaFin.Checked)
            {
                fechaFin = dateTimePickerFin.Value;
            }


          


            bool resultado = Conexion.FiltrarVentas(dataGridViewVentas, fechaInicio, fechaFin);


            if (!resultado)
            {
                MessageBox.Show("Error al filtrar las ventas.");
            }
        }
    }



}

