using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using System.Data.Entity;


namespace Negocio
{
    public class MascotaController
    {
        public static List<Mascota> getMascota()
        {
            using (ClinicaVeterinariaDBEntities database = new ClinicaVeterinariaDBEntities())
            {
                database.Configuration.LazyLoadingEnabled = false;               
                return database.Mascota.ToList();
            }
        }
    }
}
