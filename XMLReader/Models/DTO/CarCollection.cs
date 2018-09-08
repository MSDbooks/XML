using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XMLReader.Models.DTO
{

    public class Car
    {
        [XmlElement("StockNumber")]
        public string StockNumber { get; set; }

        [XmlElement("Make")]
        public string Make { get; set; }

        [XmlElement("Model")]
        public string Model { get; set; }

    }

    public class CarCollection
    {
        [XmlArray("Cars")]
        public Car[] Car { get; set; }

    }
}
