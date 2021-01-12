using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Security.Cryptography;

namespace _20201105___Criptografia
{
    class Criptografia
    {
        public struct Credenciais
        {
            public byte[] chave;
            public byte[] vetorIncializacao;
        }
        
        public static Credenciais GeraChave()
        {
            Credenciais dados = new Credenciais();
            using (AesManaged aes = new AesManaged())
            {
                dados.chave = aes.Key;
                dados.vetorIncializacao = aes.IV;
            }
            return dados;
        }

        public static byte[] CriptografaMensagem(string texto, byte[] chave, byte[] vetorIncializacao)
        {
            byte[] dadosCriptografados;

            using (AesManaged aes = new AesManaged())
            {
                ICryptoTransform criptografador = aes.CreateEncryptor(chave, vetorIncializacao);
                using (MemoryStream mensagem = new MemoryStream())
                {
                    using (CryptoStream criptoStream = new CryptoStream(mensagem, criptografador, CryptoStreamMode.Write))
                    {
                        using (StreamWriter escreve = new StreamWriter(criptoStream))
                        escreve.Write(texto);
                        dadosCriptografados = mensagem.ToArray();
                    }
                }
            }
            return dadosCriptografados;
        }

        public static string DescriptografaMensagem(byte[] textoCriptografado, byte[] chave, byte[] vetorInicializacao)
        {
            string textoDescriptografado = null;

            using (AesManaged aes = new AesManaged())
            {
                ICryptoTransform descriptografador = aes.CreateDecryptor(chave, vetorInicializacao);
                using (MemoryStream mensagem = new MemoryStream(textoCriptografado))
                {
                    using (CryptoStream escreve = new CryptoStream(mensagem, descriptografador, CryptoStreamMode.Read))
                    {
                        using (StreamReader leitor = new StreamReader(escreve))
                        textoDescriptografado = leitor.ReadToEnd();
                    }
                }
            }
            return textoDescriptografado;
        }
    }
}
