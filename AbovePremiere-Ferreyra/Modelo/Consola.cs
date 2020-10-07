using System;
using System.Diagnostics;

namespace AbovePremiere_Ferreyra.Modelo
{
    class Consola
    {
        ProcessStartInfo psi;

        public Consola()
        {
            this.psi = new ProcessStartInfo();
            psi.FileName = "cmd.exe";
            psi.WindowStyle = ProcessWindowStyle.Hidden;
        }

        public void usarConsola(String comando)
        {
            this.psi.Arguments = @"/c "+comando;
            Process.Start(this.psi);
        }
    }
}
