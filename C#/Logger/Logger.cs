using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Runtime.Serialization;

namespace Logger
{
    public class Logger
    {
        public static bool ativo = false;// habilita/desabilita o logger
        private string pathToSave;//caminho em que os logs serão salvos
        private string formatToSave;//formato da data/hora da mensagem de para cada dado loggado
        private string extensionsToSave;//extensões nas quais os logs serão salvos (eg. ".csv", ".txt")
        private string fileNameFormat;//formato data/hora dos nomes dos arquivos de log
        private int maxLinesPerFile = 50;//número máximo de linhas por arquivo, defaut are 50 lines
        int numLines = 0; //contador do número de linhas do arquivo que está sendo gerado

        public string d;

        #region Singleton
        private static Logger log = null;
        public static Logger GetLogger()
        {
            if (log == null) log = new Logger();
            return log;
        }
        #endregion

        private Logger()
        {
            d = "\\" + DateTime.Now.ToString("ddMMyyyyHHmmssfff");
            Message message = new Message(DateTime.Now.ToString("dd/MM/yyyy - HH:mm:ss"), "Inicializando o Logger!",  "Seja bem vindo ao nosso dadivoso logger");
        }

        public void MessageBuilder(string info, string message)
        {
            if (ativo)
            {
                Message newMessage = new Message(DateTime.Now.ToString(formatToSave), info, message);

                SaveManager(extensionsToSave, newMessage);
            }
        }

        #region Methods that load configs from .txt or .xml
        public Logger LoadConfigsFromXml(string pathToConfigFile)
        {
            XmlDocument document = new XmlDocument();
            document.Load(pathToConfigFile);
            
            pathToSave = document.GetElementsByTagName("pathToSave").Item(0).InnerText;
            formatToSave = document.GetElementsByTagName("formatToSave").Item(0).InnerText;
            extensionsToSave = document.GetElementsByTagName("extensions").Item(0).InnerText;
            fileNameFormat = document.GetElementsByTagName("fileNameFormat").Item(0).InnerText;
            maxLinesPerFile = (int)document.GetElementsByTagName("maxLinesPerFile").Item(0).InnerText;

            return log;
        }

        public Logger LoadConfigsFromTxt(string pathToConfigFile)
        {
            string[] configData = new string[5];

            using (StreamReader sr =new StreamReader(pathToConfigFile))
            {
                for (int i = 0; i < dados.Length; i++)
                {
                    configData[i] = sr.ReadLine();
                }
            }

            pathToSave = configData[0].Substring(configData[0].IndexOf(':') + 1);
            formatToSave = configData[1].Substring(configData[1].IndexOf(':') + 1);
            fileNameFormat = configData[2].Substring(configData[2].IndexOf(':') + 1);
            extensionsToSave = configData[3].Substring(configData[3].IndexOf(':') + 1);
            maxLinesPerFile = configData[4].Substring(configData[4].IndexOf(':') + 1);

            return log;
        }
        #endregion

        private void SaveManager(string extensionsToSaveFormats, Message newMessage)
        {
            string[] allFormats = extensionsToSaveFormats.Split('|');

            //to set an unlimited number of lines, just put any negative number like -1
            if (numLines == maxLinesPerFile)
            {
                d = "\\" + DateTime.Now.ToString("yyyyMMddHHmmssfff");
                numLines = 0;
            }

            foreach (string format in allFormats)
            {
                if (format.ToLower().Contains("txt"))
                    ExportToTxt(newMessage);

                if (format.ToLower().Contains("csv"))
                    ExportToCsv(newMessage);
            }
            numLines++;
        }

        private void ExportToTxt(Message newMessage)
        {
            using (StreamWriter sw = File.AppendText(pathToSave + d + ".txt"))
            {
                string texto = newMessage.date + "|" +
                               newMessage.info + "|" +
                               newMessage.message;

                sw.WriteLine(texto);
            }
        }

        private void ExportToCsv(Message newMessage)
        {
            using (StreamWriter sw = File.AppendText(pathToSave + d + ".csv"))
            {
                string texto = newMessage.date + "|" +
                               newMessage.info + "|" +
                               newMessage.message;

                sw.WriteLine(texto);
            }
        }
    }
}
