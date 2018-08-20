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

            StreamReader streamReader = new StreamReader(@"C:\xml\nfe.xml");

            XmlSerializer xmlSerialize = new XmlSerializer(typeof(Models.DTO.NfeProc));
                          
            var nf = (Models.DTO.NfeProc)xmlSerialize.Deserialize(streamReader);

        }

       

       

    }
}
