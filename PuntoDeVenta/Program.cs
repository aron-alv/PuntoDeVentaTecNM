using ABARROTES;
using System;
using System.Windows.Forms;

namespace PuntoDeVenta
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

        
            string usuarioWindows = Environment.UserName;

          
            OperacionesBD conexionBD = new OperacionesBD();

           
            if (conexionBD.AbrirConexion())
            {
              
                string rol = conexionBD.ObtenerRolUsuarioAD(usuarioWindows);

              
                if (rol == "Cajero")
                {
                
                    Application.Run(new FormVentas(conexionBD));
                }
                else if (rol == "Administrador")
                {
                   
                    Application.Run(new FormPrincipal(conexionBD));
                }
                else
                {
                 
                    Application.Run(new Form1());
                }
            }
            else
            {
                // Si la base de datos está apagada, abrimos el Login para que vean que hay error
                Application.Run(new Form1());
            }
        }
    }
}