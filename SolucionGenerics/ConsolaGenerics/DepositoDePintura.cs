using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaGenerics
{
    public class DepositoDePintura
    {
        public List<Producto> listaDePinturas;
        public int cantidadMaxima;

        #region Constructores

        public DepositoDePintura(int cantidadMaxima)
        {
            this.cantidadMaxima = cantidadMaxima;
            this.listaDePinturas = new List<Producto>();
        }

        #endregion

        #region Metodos

        public bool Agregar(Producto unProducto)
        {
            return this + unProducto;
        }

        public bool noHayLugar()
        {
            if (this.listaDePinturas.Count >= this.cantidadMaxima)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool existeElElemento(Producto unProducto)
        {
            foreach (Producto item in this.listaDePinturas)
            {
                if (item == unProducto)
                {
                    return true;
                }
            }

            return false;
        }

        #endregion

        #region Sobrecargas

        public static bool operator +(DepositoDePintura miDeposito, Producto unProducto)
        {
            if (!miDeposito.noHayLugar() && !miDeposito.existeElElemento(unProducto))
            {
                miDeposito.listaDePinturas.Add(unProducto);
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion
    }
}
