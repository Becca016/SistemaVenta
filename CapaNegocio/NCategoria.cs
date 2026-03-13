 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using CapaDato;
using System.Data;

namespace CapaNegocio
{
    public class NCategoria
    {
        //Mètodo Insertar que llama al mètodo Insertar de la clase DCategoria
        // de la CapaDato

        public static string Insertar(string nombre, string descripcion)
        {
            //El Obj es un objeto que hace instancia a la clase de Dcategoria y en la clase DCategoria se encuentra
            // el método nombre y descripcion
            DCategoria Obj = new DCategoria();
            Obj.Nombre = nombre;
            Obj.Descripcion = descripcion;
            return Obj.Insertar(Obj);
        }

        //Mètodo Editar que llama al mètodo Editar de la clase DCategoria
        // de la CapaDato
        public static string Editar(int idcategoria,string nombre,string descripcion)
        {
            DCategoria Obj = new DCategoria();
            Obj.Idcategoria = idcategoria;
            Obj.Nombre = nombre;
            Obj.Descripcion = descripcion;
            return Obj.Editar(Obj);                
                               
         }
        //Mètodo Eliminar que llama al mètodo Eliminar de la clase DCategoria
        // de la CapaDato
        public static string Eliminar(int idcategoria)

        {
            DCategoria Obj = new DCategoria();
            Obj.Idcategoria = idcategoria;
            return Obj.Eliminar(Obj);
        }

        //Mètodo Mostrar que llama al mètodo Mostrar de la clase DCategoria
        // de la CapaDato

        public static DataTable Mostrar()
        {
            return new DCategoria().Mostrar();
        }
        //Mètodo BuscarNombre que llama al mètodo BuscarNombre de la clase DCategoria
        // de la CapaDato

        public static DataTable BuscarNombre(string textobuscar)
        {
            DCategoria Obj = new DCategoria();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarNombre(Obj);
        }
    }
}
