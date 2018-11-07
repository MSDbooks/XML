using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLReader
{
    public class InsertNFe
    {
        public void Salvar(Models.DTO.RootObject nf)
        {
            using(var repository = new Models.Repository.NFeRepository())
            {
                repository.insertNFe(nf);
            }

        }
    }
}
