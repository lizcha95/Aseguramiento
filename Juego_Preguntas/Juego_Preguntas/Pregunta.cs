using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoPreguntas
{
    public class Pregunta
    {
        // Funciones que revisan el archivo y su consistencia

        // Revisa si el archivo existe en la directorio
        bool verificarArchivoExiste(string archivo) 
        {
            throw new NotImplementedException();
        }

        bool verificarExtension(string archivo)
        {
            throw new NotImplementedException();
        }
        void leerArchivo(string nombreArchivo)
        {
            throw new NotImplementedException();
        }
        bool verificarTamanoNombreArchivo()
        {
            throw new NotImplementedException();
        }
        bool verificarTamanoArchivo(string archivo)
        {
            throw new NotImplementedException();
        }

        // Funciones que verifican que la estructura de las preguntas esté correcta
        bool verificarEstructuraPreguntas(string archivo)
        {
            throw new NotImplementedException();
        }
        int cantidadPreguntas()
        {
            throw new NotImplementedException();
        }

        // Funciones de interacción del usuario con 
        bool verificarNumIngresado(int num)
        {
            throw new NotImplementedException();
        }
        void eliminarPregunta(int idPregunta) 
        {
            throw new NotImplementedException();
        }
        void editarPregunta(int idPregunta, Pregunta pregunta)
        {
            throw new NotImplementedException();
        }
        void agregarPregunta(Pregunta pregunta)
        {
            throw new NotImplementedException();
        }
        bool verificarPreguntaExiste(int idPregunta)
        {
            throw new NotImplementedException();
        }
        int sumarPuntaje()
        {
            throw new NotImplementedException();
        }
        int restarPuntaje()
        {
            throw new NotImplementedException();
        }
        bool verificarRespuesta(int idPregunta, int respuesta)
        {
            throw new NotImplementedException();
        }
        int incrementarDificultad()
        {
            throw new NotImplementedException();
        }

    }
}
