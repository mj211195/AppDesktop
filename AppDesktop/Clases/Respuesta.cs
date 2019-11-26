using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDesktop.Clases
{
    public class Respuesta : IEquatable<Respuesta>
    {
        public String respuesta { get; set; }
        public bool correcta { get; set; }


        //Se reescribe el método Equals para que solo compare el contenido del string de cada respuesta y el boolean
        public bool Equals(Respuesta other)
        {
            bool iguales = false;
            if (this.respuesta == other.respuesta && this.correcta == other.correcta)
            {
                iguales = true;
            }
            return iguales;
        }
    }
}
