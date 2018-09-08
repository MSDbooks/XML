using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XMLReader
{
    public class XMLRead
    {
       
        public void DeserializeXML()
        {
            
            

            StreamReader streamReader = new StreamReader(@"C:\xml\carros.xml");
            Models.DTO.Utils.RemoveAllNamespaces(streamReader.ReadLine());




            XmlSerializer xmlSerialize = new XmlSerializer(typeof(Models.DTO.nfeProc));
                          
            var nf = (Models.DTO.nfeProc)xmlSerialize.Deserialize(streamReader);

            Console.ReadLine();

        }

       

       

    }
}
