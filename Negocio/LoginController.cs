using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using System.Data.Entity;

namespace Negocio
{
   public class LoginController
    {
        public static Recepcionista recepcionistadatos;
        public static bool validate(Recepcionista recepcionista)
        {
            using (ClinicaVeterinariaDBEntities database = new ClinicaVeterinariaDBEntities())
            {
                try { 
                    var rece = database.Recepcionista.Where(r => r.IdRecepcionista == recepcionista.IdRecepcionista).First();
                    if (rece.Contrasenia == GetStringSha256Hash(recepcionista.Contrasenia))
                    {
                        recepcionistadatos = rece;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                   
                }
                catch (Exception ex){
                    throw;
                }
                
            }
        }
        public static string GetStringSha256Hash(string text)
        {
            if (String.IsNullOrEmpty(text))
                return String.Empty;

            using (var sha = new System.Security.Cryptography.SHA256Managed())
            {
                byte[] textData = System.Text.Encoding.UTF8.GetBytes(text);
                byte[] hash = sha.ComputeHash(textData);
                return BitConverter.ToString(hash).Replace("-", String.Empty);
            }
        }
    }
}
