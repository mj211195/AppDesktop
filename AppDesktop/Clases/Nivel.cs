using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDesktop.Clases
{
    public class Nivel
    {
        public BindingList<Pregunta> infantil { get; set; }
        public BindingList<Pregunta> facil { get; set; }
        public BindingList<Pregunta> medio { get; set; }
        public BindingList<Pregunta> dificil { get; set; }

        public Nivel()
        {
            infantil = new BindingList<Pregunta>();
            facil = new BindingList<Pregunta>();
            medio = new BindingList<Pregunta>();
            dificil = new BindingList<Pregunta>();
        }
    }
}
