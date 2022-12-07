using Microsoft.EntityFrameworkCore;

namespace CRUDNet7MVC.Controllers.Datos
{
    public class ApplicationDBContext: DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }

        //Agregar aquí los modelos
    }
}
