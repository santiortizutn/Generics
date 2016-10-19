using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaGenerics
{
    public class Producto
    {
        public int codigo;
        public float precioVenta;
        public string descripcion;

        #region Constructores

        public Producto(string descripcion, int codigo, float precioVenta)
        {
            this.codigo = codigo;
            this.descripcion = descripcion;
            this.precioVenta = precioVenta;
        }

        #endregion

        #region Sobrecargas

        public override string ToString()
        {
            StringBuilder sbProducto;
            sbProducto = new StringBuilder();

            sbProducto.AppendLine("---PRODUCTO---");
            sbProducto.AppendLine("Descripcion: "+this.descripcion);
            sbProducto.AppendLine("Precio de venta: "+ this.precioVenta);
            sbProducto.AppendLine("Codigo: "+this.codigo);

            return sbProducto.ToString();
        }

        public static bool operator ==(Producto productoUno, Producto productoDos)
        {
            if (productoUno.codigo == productoDos.codigo)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Producto productoUno, Producto productoDos)
        {
            if (productoUno.codigo != productoDos.codigo)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override bool Equals(object obj)
        {
            try
            {
                if (this == (Producto)obj)
                {
                    return true;
                }
            }
            catch (Exception)
            {
                
            }

            return false;
        }


        #endregion
    }
}
