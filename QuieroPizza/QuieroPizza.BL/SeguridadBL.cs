using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace QuieroPizza.BL
{
    public class SeguridadBL
    {
        Contexto _contexto;

        public SeguridadBL()
        {
            _contexto = new Contexto();
        }

        public bool Autorizar(string nombreUsuario, string contrasena)
        {
            var contrasenaEncriptada = Encriptar.CodificarContrasena(contrasena);
            var usuario = _contexto.Usuarios
                .FirstOrDefault(r => r.Nombre == nombreUsuario &&
                r.Contrasena == contrasenaEncriptada);

            if (usuario != null)
            {
                return true;
            }

            return false;
        }
    }

    public static class Encriptar {
        public static string CodificarContrasena(string contrasena)
        {
            var salt = "UNAH";

            byte[] bIn = Encoding.Unicode.GetBytes(contrasena);
            byte[] bSalt = Convert.FromBase64String(salt);
            byte[] bAll = new byte[bSalt.Length + bIn.Length];

            Buffer.BlockCopy(bSalt, 0, bAll, 0, bSalt.Length);
            Buffer.BlockCopy(bIn, 0, bAll, bSalt.Length, bIn.Length);
            HashAlgorithm s = HashAlgorithm.Create("SHA512");
            byte[] bRet = s.ComputeHash(bAll);

            return Convert.ToBase64String(bRet);
        }
    }
}
