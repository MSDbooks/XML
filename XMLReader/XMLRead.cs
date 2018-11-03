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

            //foreach (string file in Directory.EnumerateFiles(@"C:\xml",  "*.xml"))
            //{
            //    string contents = File.ReadAllText(file);
            //}

            StreamReader streamReader = new StreamReader(@"C:\xml\nfe.xml");

            //remove namespace do xml
            string xml = Models.DTO.Utils.RemoveAllNamespaces(streamReader.ReadToEnd());
            
            XmlSerializer xmlSerialize = new XmlSerializer(typeof(Models.DTO.nfeProc));
            //converte string par memory stream
            MemoryStream memStream = new MemoryStream(Encoding.UTF8.GetBytes(xml));

            var nf = (Models.DTO.nfeProc)xmlSerialize.Deserialize(memStream);

            new InsertNFe().Salvar(nf);
           

            Console.ReadLine();

        }

       

       

    }
}
