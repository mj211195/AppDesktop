using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDesktop.Clases
{
    public class Pregunta
    {
        public String pregunta { get; set; }
        public BindingList<Respuesta> respuestas { get; set; }

        //Constructores
        public Pregunta()
        {
        }
        public Pregunta(String pregunta, BindingList<Respuesta> respuestas)
        {
            this.respuestas = new BindingList<Respuesta>();
            this.pregunta = pregunta;

            foreach (Respuesta r in respuestas)
            {
                this.respuestas.Add(r);
            }
        }
    }
}
