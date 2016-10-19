using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaGenerics
{
    public class Deposito<T> : IEnumerable<T>
    {
        public List<T> listaDePinturas;
        public int cantidadMaxima;

        #region Constructores

        public Deposito(int cantidadMaxima)
        {
            this.cantidadMaxima = cantidadMaxima;
            this.listaDePinturas = new List<T>();
        }

        #endregion

        #region Metodos

        public bool Agregar(T item)
        {
            return this + item;
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

        public bool existeElElemento(T itemDos)
        {
            foreach (T item in this.listaDePinturas)
            {
                if (item.Equals(itemDos))
                {
                    return true;
                }
            }

            return false;
        }

        #endregion

        #region Sobrecargas

        public static bool operator +(Deposito<T> miDeposito, T item)
        {
            if (!miDeposito.noHayLugar() && !miDeposito.existeElElemento(item))
            {
                miDeposito.listaDePinturas.Add(item);
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
