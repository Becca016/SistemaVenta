using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using CapaDato;
using System.Data;


namespace CapaNegocio
{
    public class NArticulo
    {
        //Mètodo Insertar que llama al mètodo Insertar de la clase DArticulo
        // de la CapaDato

        public static string Insertar(string codigo, string nombre, string descripcion, byte [] imagen, int idcategoria,int idpresentacion)

        {
            DArticulo Obj = new DArticulo();
            Obj.Codigo = codigo;
            Obj.Nombre = nombre;
            Obj.Descripcion = descripcion;
            Obj.Imagen = imagen;
            Obj.Idcategoria = idcategoria;
            Obj.Idpresentacion = idpresentacion;
            return Obj.Insertar(Obj);
        }

        //Mètodo Editar que llama al mètodo Editar de la clase DArticulo
        // de la CapaDato
        public static string Editar(int idarticulo,string codigo, string nombre, string descripcion, byte[] imagen, int idcategoria, int idpresentacion)
        {
            DArticulo Obj = new DArticulo();
            Obj.Idarticulo = idarticulo;
            Obj.Codigo = codigo;
            Obj.Nombre = nombre;
            Obj.Descripcion = descripcion;
            Obj.Imagen = imagen;
            Obj.Idcategoria = idcategoria;
            Obj.Idpresentacion = idpresentacion;
            return Obj.Editar(Obj);

        }
        //Mètodo Eliminar que llama al mètodo Eliminar de la clase DArticulo
        // de la CapaDato
        public static string Eliminar(int idarticulo)

        {
            DArticulo Obj = new DArticulo();
            Obj.Idarticulo = idarticulo;
            return Obj.Eliminar(Obj);
        }

        //Mètodo Mostrar que llama al mètodo Mostrar de la clase DArticulo
        // de la CapaDato

        public static DataTable Mostrar()
        {
            return new DArticulo().Mostrar();
        }
        //Mètodo BuscarNombre que llama al mètodo BuscarNombre de la clase DArticulo
        // de la CapaDato

        public static DataTable BuscarNombre(string textobuscar)
        {
            DArticulo Obj = new DArticulo();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarNombre(Obj);
        }

    }
}
