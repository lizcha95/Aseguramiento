using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego_Preguntas.UI
{
    public class Run
    {
        private static List<Preguntas> PreguntasJuego;

        private Run()
        { }

        public static List<Preguntas> Instance
        {
            get
            {
                if (PreguntasJuego == null)
                {
                    PreguntasJuego = new List<Preguntas>();
                }
                return PreguntasJuego;
            }
        }
    }
}