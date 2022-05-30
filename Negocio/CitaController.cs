using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocio;
using Entidad;

namespace Negocio
{
    public class CitaController
    {
        public static List<Cita> getCita()
        {
            using (ClinicaVeterinariaDBEntities database = new ClinicaVeterinariaDBEntities())
            {
                database.Configuration.LazyLoadingEnabled = false;
                //return database.Mascota.Include(m => m.Duenio).ToList();
                return database.Cita.ToList();
            }
        }
    }
}
