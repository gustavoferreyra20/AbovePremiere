using AbovePremiere_Ferreyra.Modelo;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AbovePremiere_Ferreyra.FFMPEG
{
    class ffmpegHandler
    {
        static Consola consola = new Consola();

        public static void cambiarFormato(String entrada, String salida)
        {
            consola.usarConsola(@"ffmpeg -i " + entreComillas(entrada) + " " + entreComillas(salida));
        }

        public static void cambiarResolucion(String archivo, String resolucionDeleccionada, String salida)
        {
            consola.usarConsola(@"ffmpeg -i " + entreComillas(archivo) + " -vf scale=" + resolucionDeleccionada + " " + entreComillas(salida));
        }

        public static void sacarCapturas(String entrada, decimal frames, String salida)
        {
            decimal framesDecimales = frames;
            string framesString = framesDecimales.ToString(CultureInfo.InvariantCulture);
            consola.usarConsola(@"ffmpeg -i " + entreComillas(entrada) + " -vf fps=" + framesString + " " + entreComillas(salida));
        }

        public static void eliminarAudio(String archivo, String framesEntreCapturas)
        {
            consola.usarConsola(@"md C:\Users\ferre\Desktop\sifuncionaxd2");
        }

        private static String entreComillas(String direccionBase)
        {
            return '"' + direccionBase + '"';
        }

        internal static void sobreEscribir(string respuesta)
        {
            consola.usarConsola(@"" + respuesta);
        }
    }
}
