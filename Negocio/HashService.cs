
using System;
using System.Security.Cryptography;
using System.Text;

namespace Negocio
{
    public class HashService : IHashService, IVerificarHashService
    {
        public string GenerarHash(string textoPlano)
        {
            using (SHA512 sha512 = SHA512.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(textoPlano);
                byte[] hash = sha512.ComputeHash(bytes);

                return BitConverter.ToString(hash).Replace("-", "");
            }
        }

        public bool VerificarHash(string textoPlano, string hashAlmacenado)
        {
            if (textoPlano == null || string.IsNullOrEmpty(hashAlmacenado))
                return false;

            byte[] generado;
            byte[] almacenado;

            try
            {
                generado = ConvertirHexABytes(GenerarHash(textoPlano));
                almacenado = ConvertirHexABytes(hashAlmacenado);
            }
            catch (FormatException)
            {
                return false;
            }

            // Comparación en tiempo constante
            int diferencia = generado.Length ^ almacenado.Length;

            for (int i = 0; i < generado.Length; i++)
            {
                byte valorAlmacenado = i < almacenado.Length
                    ? almacenado[i]
                    : (byte)0;

                diferencia |= generado[i] ^ valorAlmacenado;
            }

            return diferencia == 0;
        }

        private byte[] ConvertirHexABytes(string hex)
        {
            if (hex.Length % 2 != 0)
                throw new FormatException("Hash hexadecimal inválido.");

            byte[] bytes = new byte[hex.Length / 2];

            for (int i = 0; i < bytes.Length; i++)
            {
                bytes[i] = Convert.ToByte(hex.Substring(i * 2, 2), 16);
            }

            return bytes;
        }
    }
}
