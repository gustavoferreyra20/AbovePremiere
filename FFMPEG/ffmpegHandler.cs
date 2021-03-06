﻿using AbovePremiere_Ferreyra.Modelo;
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
            consola.usarConsola(@"ffmpeg -i " + entreComillas(entrada) + " -y " + entreComillas(salida));
        }

        public static void cambiarResolucion(String entrada, String resolucionDeleccionada, String salida)
        {
            consola.usarConsola(@"ffmpeg -i " + entreComillas(entrada) + " -vf scale=" + resolucionDeleccionada + " -y " + entreComillas(salida));
        }

        public static void sacarCapturas(String entrada, decimal framesDecimales, String salida)
        {
            string framesString = framesDecimales.ToString(CultureInfo.InvariantCulture);
            consola.usarConsola(@"ffmpeg -i " + entreComillas(entrada) + " -vf fps=" + framesString + " -y " + entreComillas(salida));
        }

        public static void extraerAudio(String entrada, String salida)
        {
            consola.usarConsola(@"ffmpeg -i " + entreComillas(entrada) + " -vn -ar 44100 -ac 2 -ab 192 -f mp3 " + entreComillas(salida));
        }

        internal static void mutear(String entrada, String salida)
        {
            consola.usarConsola(@"ffmpeg -i " + entreComillas(entrada) + " -c copy -an " + entreComillas(salida));
        }

        private static String entreComillas(String direccionBase)
        {
            return '"' + direccionBase + '"';
        }
    }
}
