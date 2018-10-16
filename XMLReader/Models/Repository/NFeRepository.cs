using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Dapper.Contrib.Extensions;

namespace XMLReader.Models.Repository
{
    class NFeRepository : Repository, IRepository
    {

        public void insertNFe(Models.DTO.nfeProc nf)
        {
            var query = @"SELECT ID FROM EMITENTE 
                            WHERE CNPJ = @CNPJ";

            var idEmitente = GetConnection().Query<int>(query, new { CNPJ = nf.NFe.infNFe.emit.CNPJ }).FirstOrDefault();
            //se não existir emitente, inclui e retorna o id
            if (idEmitente == 0)
            {

                query = @"INSERT INTO  EMITENTE VALUES (
                              ID = 0, CNPJ = @CNPJ, xNome = @xNome, xFant = @xFant, IE = @IE
                         )
                         SELECT SCOPE_IDENTITY()";

                idEmitente = GetConnection().Query<int>(query, new
                {
                    CNPJ = nf.NFe.infNFe.emit.CNPJ,
                    xNome = nf.NFe.infNFe.emit.xNome,
                    xFant = nf.NFe.infNFe.emit.xFant,
                    IE = nf.NFe.infNFe.emit.IE
                })
                .FirstOrDefault();
            }


            if(idEmitente != 0)
            {


                DTO.IDENTIFICACAO_nfe identificacaoNFe = new DTO.IDENTIFICACAO_nfe
                {
                    ID = 0,
                    cUF =  int.Parse(nf.NFe.infNFe.emit.CNPJ),
                    cNF = nf.NFe.infNFe.emit.xNome,
                    natOp = nf.NFe.infNFe.emit.xFant,
                    nNF = int.Parse(nf.NFe.infNFe.emit.IE),
                    dhEmi = new DateTime(),
                    EMITENTE = idEmitente
                };

                GetConnection().Insert(identificacaoNFe);
            }



            
        }

    }
}
