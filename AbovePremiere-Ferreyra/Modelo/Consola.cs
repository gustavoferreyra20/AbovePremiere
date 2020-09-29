using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
