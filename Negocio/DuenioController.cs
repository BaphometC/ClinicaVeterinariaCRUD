using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;

namespace Negocio
{
    public class DuenioController
    {
        public static List<Duenio> getDuenios()
        {
            using (ClinicaVeterinariaDBEntities database = new ClinicaVeterinariaDBEntities())
            {
                database.Configuration.LazyLoadingEnabled = false;
                return database.Duenio.ToList();
            }
        }
        public static Duenio getDuenio(int id)
        {
            using (ClinicaVeterinariaDBEntities database = new ClinicaVeterinariaDBEntities())
            {
                database.Configuration.LazyLoadingEnabled = false;
                return database.Duenio.Where(d => d.IdDuenio == id).First();
            }
        }
        public static void storeDuenio(Duenio newduenio)
        {
            using (ClinicaVeterinariaDBEntities database = new ClinicaVeterinariaDBEntities())
            {
                database.Configuration.LazyLoadingEnabled = false;
                database.Duenio.Add(newduenio);
                database.SaveChanges();
            }
        }
        public static Duenio updateDuenio(Duenio newDuenio, int id)
        {
            using (ClinicaVeterinariaDBEntities database = new ClinicaVeterinariaDBEntities())
            {
                database.Configuration.LazyLoadingEnabled = false;
                Duenio duenio = database.Duenio.Where(d => d.IdDuenio == id).First();
                duenio = newDuenio;
                database.SaveChanges();
                return duenio;
            }
        }
        public static Duenio deleteDuenio(int id)
        {
            using (ClinicaVeterinariaDBEntities database = new ClinicaVeterinariaDBEntities())
            {
                database.Configuration.LazyLoadingEnabled = false;
                Duenio duenio = database.Duenio.Where(d => d.IdDuenio == id).First();
                database.Duenio.Remove(duenio);
                database.SaveChanges();
                return duenio;
            }
        }
    }
}
