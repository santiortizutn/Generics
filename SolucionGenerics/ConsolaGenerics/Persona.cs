using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaGenerics
{
    public class Persona
    {
        public string nombre;
        public int dni;

        #region Constructores

        public Persona(string nombre, int dni)
        {
            this.nombre = nombre;
            this.dni = dni;
        }

        #endregion

        #region Sobrecargas

        public override string ToString()
        {
            StringBuilder sbPersona;
            sbPersona = new StringBuilder();

            sbPersona.AppendLine("---PERSONA---");
            sbPersona.AppendLine("Nombre: " + this.nombre);
            sbPersona.AppendLine("DNI: " + this.dni);
            
            return sbPersona.ToString();
        }

        public static bool operator ==(Persona personaUno, Persona personaDos)
        {
            if (personaUno.dni == personaDos.dni)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Persona personaUno, Persona personaDos)
        {
            if (personaUno.dni != personaDos.dni)
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
                if (this == (Persona)obj)
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
