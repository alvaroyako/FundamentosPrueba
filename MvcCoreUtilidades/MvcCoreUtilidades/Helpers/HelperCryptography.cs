using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MvcCoreUtilidades.Helpers
{
    public static class HelperCryptography
    {
        public static string EncriptarTextoBasico(string contenido)
        {
            byte[] entrada;
            byte[] salida;
            UnicodeEncoding encoding = new UnicodeEncoding();
            SHA1Managed sha = new SHA1Managed();
            entrada = encoding.GetBytes(contenido);
            salida = sha.ComputeHash(entrada);
            string resultado = encoding.GetString(salida);
            return resultado;
        }

        private static string GenerateSalt()
        {
            Random random = new Random();
            string salt = "";
            for (int i = 1; i <= 50; i++)
            {
                int aleat = random.Next(0, 255);
                char letra = Convert.ToChar(aleat);
                salt += letra;
            }
            return salt;
        }

        public static string Salt { get; set; }

        public static string EncriptarContenido(string contenido,bool comparar)
        {
            if (comparar == false)
            {
                Salt = GenerateSalt();
            }
            string contenidosalt = contenido + Salt;
            SHA256Managed sha = new SHA256Managed();
            byte[] salida;
            UnicodeEncoding encoding = new UnicodeEncoding();
            salida= encoding.GetBytes(contenidosalt);
            for(int i = 1; i <= 69; i++)
            {
                salida = sha.ComputeHash(salida);
            }
            sha.Clear();
            string resultado = encoding.GetString(salida);
            return resultado;
        }
    }
}
