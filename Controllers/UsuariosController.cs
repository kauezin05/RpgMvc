using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RpgMvc.Models;

namespace RpgMvc.Controllers
{
    public class UsuariosController : Controller
    {
        public string uriBase = "http://KaueA.somee.com/RpgApi/Usuarios/";

        [HttpGet]

        public ActionResult Index()
        {
            return View("CadastrarUsuario");
        }

        [HttpPost]
        public async Task<ActionResult> RegistrarAsync(UsuarioViewModel u)
        {
            try
            {
                HttpClient httpClient = new HttpClient();
                string uriComplementar = "Registrar";

                var content = new StringContent(JsonConvert.SerializeObject(u));
                content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

                HttpResponseMessage response = await httpClient.PostAsync(uriBase + uriComplementar, content);

                string serialized = await response.Content.ReadAsStringAsync();

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    TempData["Mensagem"] = string.Format("Usuário {0} Registrado. Faça o login", u.Username);
                    return View("AutenticarUsuario");
                }
                else
                {
                    TempData["MensagemErro"] = serialized;
                    return RedirectToAction("Index");
                }
            }
            catch (System.Exception ex)
            {
                TempData["MensagemErro"] = ex.Message;
                return RedirectToAction("Index");
            }
        }

        [HttpGet]

        public ActionResult IndexLogin()
        {
            return View("AutenticarUsuario");
        }

        [HttpPost]

        public async Task<ActionResult> AutenticarAsync(UsuarioViewModel u)
        {
            HttpClient httpClient = new HttpClient();
            string uriComplementar = "Autenticar";

            var content = new StringContent(JsonConvert.SerializeObject(u));
            content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

            HttpResponseMessage response = await httpClient.PostAsync(uriBase + uriComplementar, content);

            string serialized = await response.Content.ReadAsStringAsync();

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                HttpContext.Session.SetString("SessionTokenUsuario", serialized);
                TempData["Mensagem"] = string.Format("Bem-vindo {0}!!!", u.Username);
                return RedirectToAction("Index","Personagens");
            }
            else
            {
                TempData["MensagemErro"] = serialized;
                return IndexLogin();
            }
        }

    }
}