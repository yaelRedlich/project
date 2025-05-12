using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Dal
{
    internal static class Config
    {
        public static string configName = configName = @"..\xml\data-config.xml";
        public static int nextSaleID ;
        public static int nextProductId;
        static XElement root;
        static Config()
        {
            try
            {
                XDocument doc = XDocument.Load(configName);
                root = doc.Element("config");
                nextProductId = int.Parse(root.Element("NextProductID").Value);
                nextSaleID = int.Parse(root.Element("NextSaleID").Value);

            }
            catch (Exception ex)
            {
                nextProductId = 0;
                nextSaleID = 0;
         
            }
        }
        public static int NextProductId
        {
            get
            {
                root.Element("NextProductID").Value = nextProductId.ToString();
                int id = nextProductId++;
                root.Element("NextProductID").Value = nextProductId.ToString();
                Save(); 
                return id;

            }
        }
        public static int NextSaleID
        {
            get
            {
                int id = nextSaleID++;
                root.Element("NextSaleID").Value = nextSaleID.ToString();
                Save(); 
                return id;
            }
        }
        private static void Save()
        {
            try
            {
                XDocument doc = new XDocument(root);
                doc.Save(configName);
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ שגיאה בשמירת קובץ config: " + ex.Message);
            }
        }

    }
}
