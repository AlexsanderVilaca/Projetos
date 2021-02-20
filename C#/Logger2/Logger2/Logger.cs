using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Logger2
{
    class Logger
    {
        private string pathToSave;
        private string formatToSave;
        private string extensions;
        private string fileNameFormat;

        Logger log;
        public void GetLogger()
        {
            if (log == null) { log = new Logger(); }
        }

        public void MessageBuilder(string info, string message)
        {
            Message newMessage = new Message(DateTime.Now.ToString(formatToSave), info, message);

            SaveManager(extensions, newMessage);
            //csv, txt, xml, json
            
            //deu errado
            /*
            try
            {
                SerializeInXml(newMessage);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
             * */
            
        }
        /// <summary>
        /// seta as configurações dos logs que serão gerados
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
            
           ///Console.WriteLine(pathToSave + formatToSave + extensions + fileNameFormat);
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
        /// não deu certo
        /// </summary>
        /// <param name="newMessage"></param>
        public void SerializeInXml(Message newMessage)
        {
            FileStream stream = new FileStream(pathToSave, FileMode.Create);
            XmlSerializer serializer = new XmlSerializer(typeof(Message));
            serializer.Serialize(stream, this);
        }
    }
}
