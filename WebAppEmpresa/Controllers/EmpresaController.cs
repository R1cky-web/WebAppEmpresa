using Microsoft.AspNetCore.Mvc;
using WebAppEmpresa.Models;

namespace WebAppEmpresa.Controllers
{
    public class EmpresaController : Controller
    {
        public List<Empresa> GetEmpresa() 
        {
            var ObjEmpresa=new List<Empresa>();
            
            ObjEmpresa.Add(new Empresa
            {
                IdEmpresa = 1,
                razonsocial="inversion arequipa S.A.",
                Ruc=99883213,
                Direccion="Av. las Canelidas Nª122"
            });
            
            ObjEmpresa.Add(new Empresa
            {
                IdEmpresa = 2,
                razonsocial = "inversion Santa Catalina S.A.C.",
                Ruc = 99883213,
                Direccion = "Av. las Dalias Nª145"
            });
           
            ObjEmpresa.Add(new Empresa
            {
                IdEmpresa = 2,
                razonsocial = "Construcciones Metalicas MESA",
                Ruc = 99883213,
                Direccion = "Av. Mercedes Nª271"
            });

            return ObjEmpresa;
        }
        
        public IActionResult IndexVB()
        {
            var VBDatos =GetEmpresa();
            ViewBag.Empresa = VBDatos;
            return View();
        }
    }
}
