
using Microsoft.AspNetCore.Mvc;
using WebAppEmpresa.Data.AccesoDatos;

namespace WebAppEmpresa.Controllers
{
    public class OperacionesController : Controller
    {
        public IActionResult IndexOperacion()
        {
            var Listado = new OperacionesDA();
            TempData["Listado"] = Listado.GetOperaciones();

            return View();
        }
        public IActionResult Create() 
        { 
            var ModeloOpe = new OperacionesDA();
            var model = ModeloOpe.GetOperaciones;
            return View();
        }
    }
}
