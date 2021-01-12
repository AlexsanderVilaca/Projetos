using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.IO;

namespace _20201105___Criptografia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um texto para ser criptografado: ");
            string textoInicial = Console.ReadLine();
            byte[] textoCriptografado;
            string textoDescriptografado;

            Criptografia.Credenciais chavePessoal = new Criptografia.Credenciais();
            chavePessoal = Criptografia.GeraChave();
               
            using (AesManaged aes = new AesManaged()) 
            {
                textoCriptografado = Criptografia.CriptografaMensagem(textoInicial, chavePessoal.chave, chavePessoal.vetorIncializacao);
                textoDescriptografado = Criptografia.DescriptografaMensagem(textoCriptografado, chavePessoal.chave, chavePessoal.vetorIncializacao);
            }

            Console.WriteLine(System.Text.Encoding.UTF8.GetString(textoCriptografado));
            Console.WriteLine(textoDescriptografado);

            Console.ReadKey();
        }
    }
}
