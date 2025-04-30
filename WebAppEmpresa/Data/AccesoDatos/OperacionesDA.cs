using Microsoft.EntityFrameworkCore;
using WebAppEmpresa.Models;
namespace WebAppEmpresa.Data.AccesoDatos

{
    public class OperacionesDA
    {
        public IEnumerable<Operaciones> GetOperaciones() 
        { 
            var ListadoOperacion = new List<Operaciones>();
            using (var db = new ApplicationDbContext())
            {
                ListadoOperacion = db.Operaciones.Include(item => item.Estado).Include(item => item.Responsable).ToList();
            }
            return ListadoOperacion;
        }
    }
}
