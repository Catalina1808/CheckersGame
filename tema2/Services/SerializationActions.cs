using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Serialization;

namespace tema2.Services
{
    class SerializationActions
    {
        public GameBusinessLogic game;
        public SerializationActions(GameBusinessLogic game)
        {
            this.game = game;
        }
        public void SerializeObject(GameBusinessLogic entity)
        {
            XmlSerializer xmlser = new XmlSerializer(typeof(GameBusinessLogic));
            FileStream fileStr = new FileStream("output.xml", FileMode.Create);
            xmlser.Serialize(fileStr, entity);
            fileStr.Dispose();
            MessageBox.Show("Jocul a fost salvat!");
        }

        public void DeserializeObject()
        {
            XmlSerializer xmlser = new XmlSerializer(typeof(GameBusinessLogic));
            FileStream file = new FileStream("output.xml", FileMode.Open);
            var game = (xmlser.Deserialize(file) as GameBusinessLogic);
            this.game = game;
            file.Dispose();
        }
    }
}