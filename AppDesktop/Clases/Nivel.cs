using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDesktop.Clases
{
    class Nivel
    {
        public List<Pregunta> infantil { get; set; }
        public List<Pregunta> adultoFacil { get; set; }
        public List<Pregunta> adultoIntermedio { get; set; }
        public List<Pregunta> adultoDificil { get; set; }
    }
}
