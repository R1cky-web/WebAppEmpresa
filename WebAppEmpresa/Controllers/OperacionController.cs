using Microsoft.AspNetCore.Mvc;
using WebAppEmpresa.Models;

namespace WebAppEmpresa.Controllers
{
    public class OperacionController : Controller
    {
        public List<Operacion> GetOperacion()
        {
            var ListOperacion=new List<Operacion>();
            ListOperacion.Add(new Operacion
            {
                idOperacion = 1,
                Descripcion = "Construccion de habitacion",
                Cantidad =1,
                Importe  =100000,
                //Igv=18000,
                //total=118000,
                Responsable="Juan Ramirez",
                registro=DateTime.Now,
                Estado="activo"
            });
            ListOperacion.Add(new Operacion
            {
                idOperacion = 2,
                Descripcion = "Construccion de vivienda",
                Cantidad = 1,
                Importe = 200000,
                //Igv = 36000,
                //total = 236000,
                Responsable = "Jorge Sanchez",
                registro= DateTime.Now,
                Estado="activo"
            });
            ListOperacion.Add(new Operacion
            {
                idOperacion = 3,
                Descripcion = "Construccion de caminos",
                Cantidad = 1,
                Importe = 100000,
                //Igv = 18000,
                //total = 118000,
                Responsable = "Luis Perez ",
                registro = DateTime.Now,
                Estado="activo"
            });
            ListOperacion.Add(new Operacion
            {
                idOperacion = 4,
                Descripcion = "Fabricacion de Tijerales",
                Cantidad = 1,
                Importe = 300000,
                //Igv = 54000,
                //total = 354000,
                Responsable = "Carlos Torres",
                registro = DateTime.Now,
                Estado="activo"
            });
            ListOperacion.Add(new Operacion
            {
                idOperacion = 5,
                Descripcion = "Movimiento de tierra",
                Cantidad = 1,
                Importe = 200000,
                //Igv = 36000,
                //total = 236000,
                Responsable = "Luis Sanchez",
                registro = DateTime.Now,
                Estado="activo"
            });

            foreach (var db in ListOperacion) { 
            db.Igv=(float )((float)db.Importe* 0.18);
            db.total= (float)(db.Importe + db.Igv);
            }

            return ListOperacion;
        }

        public IActionResult Index()
        {
            var ListViewOperacion = GetOperacion();
            return View(ListViewOperacion);
        }
        public IActionResult IndexVD()
        {
            ViewData["TI"] = "Listado de Operaciones";
            ViewData["ID"] = "ID";
            ViewData["DE"] = "Descripcion";
            ViewData["CA"] = "Cantidad";
            ViewData["IM"] = "Importe";
            ViewData["IG"] = "Igv";
            ViewData["TO"] = "total";
            ViewData["RE"] = "Responsable";
            ViewData["RE"] = "Registro";

            var objOperacionVB=GetOperacion();
            ViewData["ListadoOPE"] = objOperacionVB;
            return View();
        }

    }
}
