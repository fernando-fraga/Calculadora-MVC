using calculadoraV1.Models;
using Microsoft.AspNetCore.Mvc;

namespace calculadoraV1.Controllers
{
    public class CalculadoraController : Controller
    {
        public IActionResult Index() {
            return View(new CalculadoraModel());
        }

        [HttpPost]
        public ActionResult Index(CalculadoraModel model) 
        {
            model.Resultado = model.Operador switch {
                "+" => model.Valor1 + model.Valor2,
                "-" => model.Valor1 - model.Valor2,
                "*" => model.Valor1 * model.Valor2,
                "/" => model.Valor1 / model.Valor2,
                _ => (double)0,
            };
            return View(model);
        }
    }
}
