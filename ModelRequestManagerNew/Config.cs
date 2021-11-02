using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ModelRequestManagerNew
{
    public class Config
    {
        // Dient zum laden und speichern der SQL und FTP Daten, beim laden, werden die Daten in eine Static gespeichert um von überall drauf zugreifen zu können.
        public string sqlIp { get; set; }
        public string sqlPort { get; set; }
        public string sqlDatabase { get; set; }
        public string ftpIp { get; set; }
        public string ftpPassword { get; set; }
        public static string filename { get; set; }
        string test;

        public Config()
        {
            filename = "Config.xml";
        }

        public static void SaveData(object obj)
        {
            // Speichert die Daten in eine .xml
            XmlSerializer sr = new XmlSerializer(obj.GetType());
            TextWriter writer = new StreamWriter(filename);
            sr.Serialize(writer, obj);
            writer.Close();
        }

        public void LoadDate()
        {
            // Ladet die Daten aus der .xml und speichert diese direkt in statics um von woanders darauf zugreifen zu können.
            if(File.Exists(filename))
            {
            XmlSerializer xs = new XmlSerializer(typeof(Config));
            FileStream read = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.Read);
            Config config = (Config)xs.Deserialize(read);


                Save.sqlIp = config.sqlIp;
                Save.sqlPort = config.sqlPort;
                Save.sqlDataBase = config.sqlDatabase;
                Save.ftpIp = config.ftpIp;
                Save.ftpPassword = config.ftpPassword;
                read.Close();
            }
        }

    }
}
