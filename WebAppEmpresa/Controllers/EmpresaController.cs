using Microsoft.AspNetCore.Mvc;
using WebAppEmpresa.Models;

namespace WebAppEmpresa.Controllers
{
    public class EmpresaController : Controller
    {
        // Método para obtener empresas (refactorizado)
        public List<Empresa> ObtenerEmpresas()
        {
            return
            [
                new() {
                    IdEmpresa = 1,
                    RazonSocial = "Inversion Arequipa S.A.",
                    Ruc = 99883213,
                    Direccion = "Av. las Canelidas Nª122"
                },
                new() {
                    IdEmpresa = 2,
                    RazonSocial = "Inversion Santa Catalina S.A.C.",
                    Ruc = 99883213,
                    Direccion = "Av. las Dalias Nª145"
                },
                new() {
                    IdEmpresa = 3,
                    RazonSocial = "Construcciones Metalicas MESA",
                    Ruc = 99883213,
                    Direccion = "Av. Mercedes Nª271"
                }
            ];
        }

        // Acción para mostrar la lista de empresas
        public IActionResult Index()
        {
            var empresas = ObtenerEmpresas();
            ViewBag.Empresa = empresas;
            return View();
        }
    }
}