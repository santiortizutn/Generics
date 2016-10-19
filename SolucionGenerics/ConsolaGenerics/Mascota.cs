using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaGenerics
{
    public class Mascota
    {
        public string nombre;
        public string raza;

        #region Constructores

        public Mascota(string nombre, string raza)
        {
            this.nombre = nombre;
            this.raza = raza;
        }

        #endregion

        #region Sobrecargas

        public override string ToString()
        {
            StringBuilder sbMascota;
            sbMascota = new StringBuilder();

            sbMascota.AppendLine("---MASCOTA---");
            sbMascota.AppendLine("Nombre: " + this.nombre);
            sbMascota.AppendLine("Raza: " + this.raza);
            
            return sbMascota.ToString();
        }

        public static bool operator ==(Mascota mascotaUno, Mascota mascotaDos)
        {
            if (mascotaUno.raza == mascotaDos.raza && mascotaUno.nombre == mascotaDos.nombre)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Mascota mascotaUno, Mascota mascotaDos)
        {
            if (mascotaUno.raza != mascotaDos.raza && mascotaUno.nombre != mascotaDos.nombre)
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
                if (this == (Mascota)obj)
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
