using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace XMLReader
{
    public class XMLRead
    {
       
        public void DeserializeXML()
        {

                       
            StreamReader streamReader = new StreamReader(@"C:\xml\nfe.xml");


            //remove namespace do xml
            string xml = Models.DTO.Utils.RemoveAllNamespaces(streamReader.ReadToEnd());

            //Convert xml to json string
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);
            string jsonText = JsonConvert.SerializeXmlNode(doc);

            //convert json string to object 
            var obj =JsonConvert.DeserializeObject<Models.DTO.RootObject>(jsonText);
                       
            new InsertNFe().Salvar(obj);


            Console.ReadLine();

        }

       

       

    }
}
