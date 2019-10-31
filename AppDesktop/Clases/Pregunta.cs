using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDesktop.Clases
{
    class Pregunta
    {
        public String pregunta { get; set; }
        public List<Respuesta> respuestas { get; set; }

        public Pregunta() { }

        public Pregunta(String pregunta, List<Respuesta> respuestas)
        {
            this.pregunta = pregunta;
            this.respuestas = respuestas;
        }
    }
}
