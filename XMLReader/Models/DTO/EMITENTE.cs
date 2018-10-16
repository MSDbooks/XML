using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace XMLReader.Models.DTO
{
    [Table("EMITENTE")]
    public class EMITENTE
    {
        [Write(false)]
        public int ID { get; set; }
        public string CNPJ { get; set; }
        public string xNome { get; set; }
        public string xFant { get; set; }
        public string IE { get; set; }
    }
}
