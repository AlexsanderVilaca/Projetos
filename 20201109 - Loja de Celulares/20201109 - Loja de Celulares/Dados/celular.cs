using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Runtime.Serialization;
using System.Xml;
using System.IO;

namespace _20201109___Loja_de_Celulares.Dados
{
    [DataContract]
    public class Celular
    {
        public Celular(int codigo, string marca, double preco, string descricao)
        {
            Codigo = codigo;
            Marca = marca;
            Preco = preco;
            Descricao = descricao;
        }
        [DataMember]
        public int Codigo { get; set; }

        [DataMember]
        public string Marca { get; set; }

        [DataMember]
        public double Preco { get; set; }

        [DataMember]
        public string Descricao { get; set; }
    }
}
