using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using CapaDato;
using System.Data;

namespace CapaNegocio
{
    public class NPresentacion
    {
        //Mètodo Insertar que llama al mètodo Insertar de la clase DPresentacion
        // de la CapaDato

        public static string Insertar(string nombre, string descripcion)
        {
            DPresentacion Obj = new DPresentacion();
            Obj.Nombre = nombre;
            Obj.Descripcion = descripcion;
            return Obj.Insertar(Obj);
        }

        //Mètodo Editar que llama al mètodo Editar de la clase DPresentacion
        // de la CapaDato
        public static string Editar(int idpresentacion, string nombre, string descripcion)
        {
           DPresentacion Obj = new DPresentacion();
            Obj.Idpresentacion = idpresentacion;
            Obj.Nombre = nombre;
            Obj.Descripcion = descripcion;
            return Obj.Editar(Obj);

        }
        //Mètodo Eliminar que llama al mètodo Eliminar de la clase DPresentacion
        // de la CapaDato
        public static string Eliminar(int idpresentacion)

        {
            DPresentacion Obj = new DPresentacion();
            Obj.Idpresentacion = idpresentacion;
            return Obj.Eliminar(Obj);
        }

        //Mètodo Mostrar que llama al mètodo Mostrar de la clase DPresentacion
        // de la CapaDato

        public static DataTable Mostrar()
        {
            return new DPresentacion().Mostrar();
        }
        //Mètodo BuscarNombre que llama al mètodo BuscarNombre de la clase DPresentacion
        // de la CapaDato

        public static DataTable BuscarNombre(string textobuscar)
        {
          DPresentacion Obj = new DPresentacion();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarNombre(Obj);
        }

    }
}
