using Microsoft.AspNetCore.Mvc;

namespace GrupoGPS_Proto.Controllers
{
    public class EmpresaController : Controller
    {
        //private readonly IHttpClientFactory _httpClientFactory;

        //public EmpresaController(IHttpClientFactory httpClientFactory)
        //{
        //    _httpClientFactory = httpClientFactory;
        //}
        public IActionResult Index()
        {
            ViewBag.greeting = "Welcome to die";
            return View();
        }

        public IActionResult BuscarEmpresa()
        {
            return View();
        }

        //[HttpGet]
        //public async Task<IActionResult> BuscarEmpresa(EmpresaViewModel model)
        //{
        //    string consultaAPI = "https://receitaws.com.br/v1/cnpj/{cnpj}";
        //    return View();

        //}

        // Metodo para gravar as informações encontradas por BuscarEmpresa()
        [HttpPost]
        public IActionResult CreateEmpresa()
        {
            return View();
        }
    }
}
