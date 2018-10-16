using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLReader.Models.DTO
{
    [Table("PRODUTO")]
    public class PRODUTO
    {
        [Write(false)]
        public int ID { get; set; }
        public string cProd { get; set; }
        public object cEAN { get; set; }
        public string xProd { get; set; }
        public string NCM { get; set; }
        public string CEST { get; set; }
        public string CFOP { get; set; }
        public string uCom { get; set; }
        public string qCom { get; set; }
        public string vUnCom { get; set; }
        public string vProd { get; set; }
        public object cEANTrib { get; set; }
        public string uTrib { get; set; }
        public string qTrib { get; set; }
        public string vUnTrib { get; set; }
        public string indTot { get; set; }
        public int IDENTIFICACAO_nfe { get; set; }

    }
}
