using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Logger
{
    public class Logger
    {
        private string pathToSave;
        private string formatToSave;
        private string extensions;
        private string fileNameFormat;

        private static Logger log = null;
        public static Logger GetLogger()
        {
            if (log == null) log = new Logger();
            return log;
        }
        private Logger()
        {
            Message message = new Message(DateTime.Now.ToString("dd/MM/yyyy - HH:mm:ss"), "Inicializando o Logger!",  "Seja bem vindo ao nosso dadivoso logger");
            SaveManager(extensions, message);
        }
        public void MessageBuilder(string info, string message)
        {
            Message newMessage = new Message(DateTime.Now.ToString(formatToSave), info, message);

            SaveManager(extensions, newMessage);
        }

        
        /// <summary>
        /// seta as configurações dos logs que serão gerados
        /// windows ce não rodou, it sucks
        /// </summary>
        /// <param name="pathToConfigFile"></param>
        public void SetConfigFile(string pathToConfigFile)
        {
            XmlDocument document = new XmlDocument();
            document.Load(pathToConfigFile);
            
            pathToSave = document.GetElementsByTagName("pathToSave").Item(0).InnerText;
            formatToSave = document.GetElementsByTagName("formatToSave").Item(0).InnerText;
            extensions = document.GetElementsByTagName("extensions").Item(0).InnerText;
            fileNameFormat = document.GetElementsByTagName("fileNameFormat").Item(0).InnerText;

            //Console.WriteLine(pathToSave + "\n" + formatToSave + "\n" + extensions + "\n" + fileNameFormat);

            //document.GetElementsByTagName("fileNameFormat").Item(0).Value = "caro";
            ///Console.WriteLine(pathToSave + formatToSave + extensions + fileNameFormat);
        }
         

        public Logger SetConfigurations(string pathToConfigFile)
        {
            string[] dados = File.ReadAllLines(pathToConfigFile);

            pathToSave = dados[0].Substring(dados[0].IndexOf(':') + 1);
            formatToSave = dados[1].Substring(dados[1].IndexOf(':') + 1);
            fileNameFormat = dados[2].Substring(dados[2].IndexOf(':') + 1);
            extensions = dados[3].Substring(dados[3].IndexOf(':') + 1);

            return log;
        }

        private void SaveManager(string extensionsFormats, Message newMessage)
        {
            string[] allFormats = extensionsFormats.Split('|');

            foreach (string format in allFormats)
            {
                if (format.ToLower().Contains("txt"))
                    SaveToTXT(newMessage);
                if (format.ToLower().Contains("csv"))
                    SaveToCSV(newMessage);
                //falta implementar serialização json e talvez o xml
            }
        }
        /// <summary>
        /// salva como .txt
        /// </summary>
        /// <param name="newMessage"></param>
        private void SaveToTXT(Message newMessage)
        {
            using (StreamWriter sw = File.AppendText(Path.Combine(pathToSave, DateTime.Now.ToString(fileNameFormat)) + ".txt"))
            {
                string texto = newMessage.date + "|" +
                               newMessage.info + "|" +
                               newMessage.message;

                sw.WriteLine(texto);
            }
        }

        private void SaveToCSV(Message newMessage)
        {
            using (StreamWriter sw = File.AppendText(Path.Combine(pathToSave, DateTime.Now.ToString(fileNameFormat)) + ".csv"))
            {
                string texto = newMessage.date + "|" +
                               newMessage.info + "|" +
                               newMessage.message;

                sw.WriteLine(texto);
            }
        }
        /// <summary>
        /// não deu certo, diga não ao windows CE
        /// </summary>
        /// <param name="newMessage"></param>
        public void SerializeInXml(Message newMessage)
        {
            FileStream stream = new FileStream(pathToSave, FileMode.Create);
            XmlSerializer serializer = new XmlSerializer(typeof(Message));
            serializer.Serialize(stream, this);
        }

        public static string ConvertToBaseAndAlign(byte[] vector, int baseToConvert)
        {
            string text = String.Empty;
            string[] datos = new string[vector.Length];

            for (int i = 0; i < vector.Length; i++)
            {
                datos[i] = vector[i].ToString("X" + baseToConvert);
                text += datos[i];
            }

            /*
            //StringBuilder aux = new StringBuilder();
            foreach (byte value in vector)
            {
                text += "0x" + Convert.ToByte(value.ToString(), baseToConvert) + " ";
            }
            return aux.ToString();
             * */

            return text;
        }

        public static string ConvertToBaseAndAlign(short[] vector, int baseToConvert)
        {
            string text = String.Empty;
            foreach (short value in vector)
            {
                text += "0x" + Convert.ToInt16(value.ToString(), baseToConvert) + " ";
            }
            return text;
        }
    }
}
