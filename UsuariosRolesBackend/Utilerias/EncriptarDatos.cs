using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace UsuariosRolesBackend.Utilerias
{
    public class EncriptarDatos
    {
        public string encriptarTexto(string texto)
        {
            byte[] sentHashValue = Convert.FromHexString("67A1790DCA55B8803AD024EE28F616A284DF5DD7B8BA5F68B4B252A5E925AF79");

            //This is the string that corresponds to the previous hash value.
            //Convert the string into an array of bytes.
            byte[] textoBytes = Encoding.UTF8.GetBytes(texto);

            //Create the hash value from the array of bytes.
            byte[] textoHash = SHA256.HashData(textoBytes);

            string textoEncriptado = Convert.ToHexString(textoHash);

            //Compare the values of the two byte arrays.
            bool same = sentHashValue.SequenceEqual(textoHash);

            //Display whether or not the hash values are the same.
            if (same)
            {
                Console.WriteLine("The hash codes match.");
            }
            else
            {
                Console.WriteLine("The hash codes do not match.");
            }
            return textoEncriptado;
        }
    }
}
