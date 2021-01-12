using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using _20201109___Loja_de_Celulares.Dados;
using System.Web.Script.Serialization;



namespace _20201109___Loja_de_Celulares
{
    public partial class frTelaCadastroAparelho : Form
    {
        public frTelaCadastroAparelho()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            int codigo;
            string descricao, marca;
            double preco;
            bool JaExiste = false;

            try
            {
                codigo = Convert.ToInt32(txtCodigo.Text);
                marca = cbMarca.SelectedItem.ToString();
                preco = Convert.ToDouble(txtPreco.Text);
                descricao = txtDescricao.Text;
            }
            catch(Exception mensagem)
            {
                MessageBox.Show(mensagem.ToString());
                return;
            }
            
            string caminhoSemExtensao = @"C:\Users\alexsander.rodrigues\Documents\Projetos C#\20201109 - Loja de Celulares\20201109 - Loja de Celulares\Dados\celulares";

            if (FuncoesAuxiliares.Buscar(caminhoSemExtensao + ".txt", txtCodigo.Text, 1) != null)
            {
                MessageBox.Show("Cadastro já existe");
                JaExiste = true;
                return;
            }
            

            if (!chkExportarTXT.Checked && !chkExportarXML.Checked && !chkExportarJSON.Checked && !JaExiste)
            {
                MessageBox.Show("Selecione alguma opção de exportação!");
                return;
            }
            else
            {
                if (chkExportarTXT.Checked)//salvando em txt
                    ExportaEmTXT(codigo, marca, preco, descricao, caminhoSemExtensao);

                if (chkExportarXML.Checked)//salvando em xml
                    ExportaEmXML(codigo, marca, preco, descricao, caminhoSemExtensao);
                
                if (chkExportarJSON.Checked)//salvando em json
                    ExportaJSON(codigo, marca, preco, descricao, caminhoSemExtensao);

                MessageBox.Show("Sucesso");
            }
        }

        private static void ExportaEmTXT(int codigo, string marca, double preco, string descricao, string caminho)
        {
            try
            {
                string dados = codigo.ToString() + ";" +
                               marca + ";" +
                               preco.ToString() + ";" +
                               descricao + Environment.NewLine;

                File.AppendAllText(caminho + ".txt", dados);
            }
            catch (Exception mensagem)
            {
                MessageBox.Show(mensagem.ToString());
                return;
            }
        }

        private static void ExportaEmXML(int codigo, string marca, double preco, string descricao, string caminho)
        {
            try
            {
                XElement elemento = new XElement("celular");
                elemento.Add(new XAttribute("codigo", codigo.ToString()));
                elemento.Add(new XAttribute("marca", marca));
                elemento.Add(new XAttribute("preco", preco.ToString()));
                elemento.Add(new XAttribute("descricao", descricao));
                XElement arquivo = XElement.Load(caminho + ".xml");
                arquivo.Add(elemento);
                arquivo.Save(caminho + ".xml");
            }
            catch (Exception mensagem)
            {
                MessageBox.Show(mensagem.ToString());
                return;
            }
        }

        private static void ExportaJSON(int codigo, string marca, double preco, string descricao, string caminho)
        {
            Celular celular = new Celular(codigo, marca, preco, descricao);
            try
            {
                string arquivos = _20201109___Loja_de_Celulares.AjudaJson.Serializar<Celular>(celular) + Environment.NewLine;
                File.AppendAllText(caminho + ".json", arquivos);
            }
            catch (Exception mensagem)
            {
                MessageBox.Show(mensagem.ToString());
                return;
            }
        }
    }
}
