using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agregar_usuario
{
    class Clientes
    {
        DBuesGymDataContext objectDB = new DBuesGymDataContext();

        //============================================
        //                   ATRIBUTES
        ///============================================
        string nombre;
        string correo;
        string tipoCliente;
        string direccion;
        string telefono;
        string telefonoDeEmergencia;
        bool statusMembresia;
        string fechaInicioMembresia;
        string fechaCorteMembresia;
        string certificadoMedico;

        //============================================
        //                   METHODS
        ///============================================
        ///modificar cliente
        public void insertarNuevoCliente(string nombre, string correo, string tipoCliente, string direccion, string telefono, string telefonoDeEmergencia, string fechaInicioMembresia, string certificadoMedico)
        {

        }

        public void EliminarCliente(int id)
        {
            if (id > 0)
            {
                try
                {
                    if (MessageBox.Show("Esta seguro que desea eliminar este cliente ? ", "Advertencia", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        //objectDB.EliminarHabitacion(id);
                        MessageBox.Show("Cliente Eliminado Correctamente", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }
        public void modificarUsuario()
        {
            //int Id_Habitaciones = int.Parse(txtId.Text);
            //String Tipo_Habitacion = txtTipoHab.Text;
            //int Numero_Habitacion = int.Parse(txtNumHab.Text);
            //int Costo_Habitacion = int.Parse(txtCosto.Text);
            //String Descripcion_Habitacion = txtDescripcion.Text;
            // objBD.ActualizarHabitacion(Id_Habitaciones, Tipo_Habitacion, Descripcion_Habitacion, Costo_Habitacion, Numero_Habitacion);
            // dataGridHabitaciones.DataSource = objBD.MostrarHabitaciones();
            // MessageBox.Show("Registro Actualizado Correctamente", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
