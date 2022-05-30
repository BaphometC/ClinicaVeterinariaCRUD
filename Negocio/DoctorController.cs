using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Negocio
{
    public class DoctorController
    {
        public static List<Doctor> getDoctor()
        {
            using (ClinicaVeterinariaDBEntities database = new ClinicaVeterinariaDBEntities())
            {
                database.Configuration.LazyLoadingEnabled = false;
                return database.Doctor.ToList();
            }
        }
    }
}
