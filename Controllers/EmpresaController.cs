using Microsoft.AspNetCore.Mvc;

namespace GrupoGPS_Proto.Controllers
{
    public class EmpresaController : Controller
    {
        // private readonly HttpClient httpClient;

        //public EmpresaController(IHttpClientFactory httpClientFactory)
        //{
        //    httpClient = httpClientFactory.CreateClient();
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
        //public async Task<IActionResult> GetEmpresa(string cnpj)
        //{
        //    var apiUrl = $"https://receitaws.com.br/v1/cnpj/{cnpj}";
        //    var response = await httpClient.GetAsync(apiUrl);

        //    if (response.IsSuccessStatusCode)
        //    {
        //        var data = await response.Content.ReadAsStringAsync();
        //        return Ok(data);
        //    }

        //    return BadRequest();

        //}
    }
}
