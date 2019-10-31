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
        public byte idNivel { get; set; }
        public byte idIdioma { get; set; }

        //Constructores
        public Pregunta() { }
        public Pregunta(String pregunta, List<Respuesta> respuestas, byte idNivel, byte idIdioma)
        {
            this.pregunta = pregunta;
            this.respuestas = respuestas;
            this.idNivel = idNivel;
            this.idIdioma = idIdioma;
        }
    }
}
