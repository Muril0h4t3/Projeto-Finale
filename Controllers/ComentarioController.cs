using Microsoft.AspNetCore.Mvc;

namespace Senai.Projeto.Final.Final.web.Mvc.Controllers {
    public class ComentarioController : Controller {
        [HttpGet]
        public IActionResult Cadastrar () {
        return View (); 
        }

        
    }
}