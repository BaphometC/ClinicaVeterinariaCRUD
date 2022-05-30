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
        public static List<Mascota> getMascotas()
        {
            using (ClinicaVeterinariaDBEntities database = new ClinicaVeterinariaDBEntities())
            {
                database.Configuration.LazyLoadingEnabled = false;               
                return database.Mascota.ToList();
            }
        }
        public static Mascota getMascota(int id)
        {
            using (ClinicaVeterinariaDBEntities database = new ClinicaVeterinariaDBEntities())
            {
                database.Configuration.LazyLoadingEnabled = false;
                return database.Mascota.Where(m => m.IdMascota == id).First();
            }
        }
        public static void storeMascota(Mascota newmascota) 
        {
            using (ClinicaVeterinariaDBEntities database = new ClinicaVeterinariaDBEntities())
            {
                database.Configuration.LazyLoadingEnabled = false;
                database.Mascota.Add(newmascota);
                database.SaveChanges();
            }
        }
        public static Mascota updateMascota(Mascota newMascota, int id)
        {
            using (ClinicaVeterinariaDBEntities database = new ClinicaVeterinariaDBEntities())
            {
                database.Configuration.LazyLoadingEnabled = false;
                Mascota mascota = database.Mascota.Where(m => m.IdMascota == id).First();
                mascota.Nombre = newMascota.Nombre;
                mascota.Edad = newMascota.Edad;
                mascota.Especie = newMascota.Especie;
                mascota.Raza = newMascota.Raza;
                mascota.IdDuenio = newMascota.IdDuenio;
                database.SaveChanges();
                return newMascota;
            }
        }
        public static Mascota deleteMascota(int id)
        {
            using (ClinicaVeterinariaDBEntities database = new ClinicaVeterinariaDBEntities())
            {
                database.Configuration.LazyLoadingEnabled = false;
                Mascota mascota = database.Mascota.Where(m => m.IdMascota == id).First();
                database.Mascota.Remove(mascota);
                database.SaveChanges();
                return mascota;
            }
        }
    }
}
