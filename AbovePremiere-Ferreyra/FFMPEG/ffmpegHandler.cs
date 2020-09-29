using AbovePremiere_Ferreyra.Modelo;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AbovePremiere_Ferreyra.FFMPEG
{
    class ffmpegHandler
    {
        static Consola consola = new Consola();

        public static void cambiarFormato(String archivo, String archivoProcesado)
        {
            consola.usarConsola(@"ffmpeg -i " + '"' + archivo + '"' + " " + archivoProcesado);
            Console.WriteLine(@"ffmpeg -i " + '"' + archivo + '"' + " " + archivoProcesado);
        }

        public static void cambiarResolucion(String archivo, String resolucionDeleccionada)
        {
            consola.usarConsola(@"md C:\Users\ferre\Desktop\sifuncionaxd2");
        }

        public static void sacarCapturas(String archivo, String framesEntreCapturas)
        {
            consola.usarConsola(@"md C:\Users\ferre\Desktop\sifuncionaxd2");
        }

        public static void eliminarAudio(String archivo, String framesEntreCapturas)
        {
            consola.usarConsola(@"md C:\Users\ferre\Desktop\sifuncionaxd2");
        }

    }
}
