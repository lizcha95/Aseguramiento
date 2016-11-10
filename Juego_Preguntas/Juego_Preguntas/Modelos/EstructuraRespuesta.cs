using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego_Preguntas
{
    public class EstructuraRespuesta
    {
        public string Respuesta { get; set; }
        public string Distractor1 { get; set; }
        public string Distractor2 { get; set; }
        public string Distractor3 { get; set; }

        public EstructuraRespuesta(string respuesta, string distractor1, string distractor2, string distractor3)
        {
            Respuesta = respuesta;
            Distractor1 = distractor1;
            Distractor2 = distractor2;
            Distractor3 = distractor3;
        }
    }
}
