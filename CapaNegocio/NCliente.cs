using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;

using CapaDato;

namespace CapaNegocio
{
    public class NCliente
    {
        //Mètodos para comunicarnos con la CapaDato

        //Mètodo Insertar que llama al mètodo Insertar de la clase DCliente

        public static string Insertar(string nombre, string apellidos, string sexo,DateTime fecha_nacimiento, string tipo_documento, string num_documento,
           string direccion, string telefono, string email)

        {
            DCliente Obj = new DCliente();
            Obj.Nombre =nombre;
            Obj.Apellidos = apellidos;
            Obj.Sexo = sexo;
            Obj.Fecha_Nacimiento = fecha_nacimiento;
            Obj.Tipo_Documento = tipo_documento;
            Obj.Num_Documento = num_documento;
            Obj.Direccion = direccion;
            Obj.Telefono = telefono;
            Obj.Email = email;

            return Obj.Insertar(Obj);
        }

        //Mètodo Editar que llama al mètodo Editar de la clase DCliente
        public static string Editar(int idcliente, string nombre, string apellidos, string sexo, DateTime fecha_nacimiento,
          string tipo_documento, string num_documento,string direccion, string telefono, string email)
        {
            DCliente Obj = new DCliente();
            Obj.Idcliente = idcliente;
            Obj.Nombre = nombre;
            Obj.Apellidos = apellidos;
            Obj.Sexo = sexo;
            Obj.Fecha_Nacimiento = fecha_nacimiento;
            Obj.Tipo_Documento = tipo_documento;
            Obj.Num_Documento = num_documento;
            Obj.Direccion = direccion;
            Obj.Telefono = telefono;
            Obj.Email = email;

            return Obj.Editar(Obj);

        }
        //Mètodo Eliminar que llama al mètodo Eliminar de la clase DCliente
        // de la CapaDato
        public static string Eliminar(int idcliente)

        {
            DCliente Obj = new DCliente();
            Obj.Idcliente = idcliente;
            return Obj.Eliminar(Obj);
        }

        //Mètodo Mostrar que llama al mètodo Mostrar de la clase DCliente
        // de la CapaDato

        public static DataTable Mostrar()
        {
            return new DCliente().Mostrar();
        }
        //Mètodo BuscarApellidos  que llama al mètodo BuscarApellidos de la clase DCliente

        public static DataTable BuscarApellidos(string textobuscar)
        {
            DCliente Obj = new DCliente();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarApellidos(Obj);

        }

        //Mètodo BuscarNum_documento  que llama al mètodo BuscarNum_documento de la clase DCliente
        // de la CapaDato

        public static DataTable BuscarNum_Documento(string textobuscar)
        {
            DCliente Obj = new DCliente();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarNum_Documento(Obj);

        }

    }
}
