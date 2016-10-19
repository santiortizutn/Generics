using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaGenerics
{
    public class Vehiculo
    {
        public string marca;
        public string color;
        public string patente;

         #region Constructores

        public Vehiculo(string marca, string color, string patente)
        {
            this.marca = marca;
            this.color = color;
            this.patente = patente;
        }

        #endregion

        #region Sobrecargas

        public override string ToString()
        {
            StringBuilder sbPersona;
            sbPersona = new StringBuilder();

            sbPersona.AppendLine("---VEHICULO---");
            sbPersona.AppendLine("Marca: " + this.marca);
            sbPersona.AppendLine("Color: " + this.color); 
            sbPersona.AppendLine("Patente: " + this.patente);
            
            return sbPersona.ToString();
        }

        public static bool operator ==(Vehiculo vehiculoUno, Vehiculo vehiculoDos)
        {
            if (vehiculoUno.patente == vehiculoDos.patente)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Vehiculo vehiculoUno, Vehiculo vehiculoDos)
        {
            if (vehiculoUno.patente != vehiculoDos.patente)
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
                if (this == (Vehiculo)obj)
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
