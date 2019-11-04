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
        public List<Pregunta> facil { get; set; }
        public List<Pregunta> medio { get; set; }
        public List<Pregunta> dificil { get; set; }
    }
}
