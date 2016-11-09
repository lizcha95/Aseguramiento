using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego_Preguntas.UI
{
    public class Run
    {
        private static Preguntas PreguntasJuego;

        private Run()
        { }

        public static Preguntas Instance
        {
            get
            {
                if (PreguntasJuego == null)
                {
                    PreguntasJuego = new Preguntas();
                }
                return PreguntasJuego;
            }
        }
    }
}