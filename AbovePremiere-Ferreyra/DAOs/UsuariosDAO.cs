using AbovePremiere_Ferreyra.Modelo;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace AbovePremiere_Ferreyra.DAOs
{
    class UsuariosDAO
    {
        public static Boolean existeUsuario(string usuario, string password)
        {
            var client = new RestClient("https://localhost:44370/");

            var request = new RestRequest(Method.POST);
            request.Resource = "User/BuscarUsuarioRegistrado";
            request.RequestFormat = DataFormat.Json;
            request.AddJsonBody(new { username = usuario, pwd = password });
            
            var response = client.Execute(request);

            return JsonConvert.DeserializeObject<string>(response.Content) != "";
        }
    }
}
