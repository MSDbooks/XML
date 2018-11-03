using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLReader.Models.DTO
{
    [Table("IDENTIFICACAO_nfe")]
    public class IDENTIFICACAO_nfe
    {

        [Write(false)]
        public int ID { get; set; }
        public long cUF { get; set; }
        public string cNF { get; set; }
        public string natOp { get; set; }
        public long nNF { get; set; }
        public DateTime dhEmi { get; set; }
        public int EMITENTE { get; set; }
    }
}
