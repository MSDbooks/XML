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

        FileInfo[] files;
        int x;

        public void DeserializeXML()
        {

            try
            {

                DirectoryInfo di = new DirectoryInfo(@"C:\xml");
                files = di.GetFiles("*.xml");

                for ( x = 0; x < files.Length; x++)
                {
                    using (StreamReader streamReader = new StreamReader(@"C:\xml\" + files[x]))
                    {
                        //remove namespace do xml
                        string xml = Models.DTO.Utils.RemoveAllNamespaces(streamReader.ReadToEnd());

                        //Convert xml to json string
                        XmlDocument doc = new XmlDocument();
                        doc.LoadXml(xml);
                        string jsonText = JsonConvert.SerializeXmlNode(doc);

                        //convert json string to object 
                        var obj = JsonConvert.DeserializeObject<Models.DTO.RootObject>(jsonText);

                        new InsertNFe().Salvar(obj);

                    }

                    File.Delete(@"C:\xml\" + files[x]);
                    
                }


            }
            catch (Exception e)
            {

                File.AppendAllText(@"c:\temp\NFElog.txt", e.ToString());

                if (File.Exists(@"C:\xml\" + files[x]))
                {
                    File.Delete(@"C:\xml\" + files[x]);
                }
                
                
            }


            Console.WriteLine("Fim");
            Console.ReadLine();

        }

       

       

    }
}
