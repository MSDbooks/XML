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
                              @CNPJ, @xNome, @xFant, @IE
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

                query = @"INSERT INTO  IDENTIFICACAO_nfe VALUES (
                             @cUF, @cNF, @natOp, @nNF, @dhEmi, @EMITENTE
                         )
                         SELECT SCOPE_IDENTITY()";

                var idIdentificacaoNFe = GetConnection().Query<int>(query, new
                {
                    cUF = int.Parse(nf.NFe.infNFe.emit.CNPJ),
                    cNF = nf.NFe.infNFe.emit.xNome,
                    natOp = nf.NFe.infNFe.emit.xFant,
                    nNF = int.Parse(nf.NFe.infNFe.emit.IE),
                    dhEmi = new DateTime(),
                    EMITENTE = idEmitente

                })
                .FirstOrDefault();


                if (idIdentificacaoNFe != 0)
                {

                    #region QUERY_PRODUTO
                    query = @"INSERT INTO  PRODUTO VALUES (
                             @cProd,
                             @cEAN,
                             @xProd,
                             @NCM,
                             @CEST,
                             @CFOP,
                             @uCom,
                             @qCom,
                             @vUnCom,
                             @vProd,
                             @cEANTrib,
                             @uTrib,
                             @qTrib,
                             @vUnTrib,
                             @indTot,
                             @IDENTIFICACAO_nfe
                         )";
                    #endregion

                    nf.NFe.infNFe.det.ForEach(item =>
                    {

                        GetConnection().Query(query, new
                        {
                            cProd = item.prod.cProd,
                            cEAN = item.prod.cEAN,
                            xProd = item.prod.xProd,
                            NCM = item.prod.NCM,
                            CEST = item.prod.CEST,
                            CFOP = item.prod.CFOP,
                            uCom = item.prod.uCom,
                            vUnCom = item.prod.vUnCom,
                            vProd = item.prod.vProd,
                            cEANTrib = item.prod.cEANTrib,
                            uTrib = item.prod.uTrib,
                            qTrib = item.prod.qTrib,
                            vUnTrib = item.prod.vUnTrib,
                            indTot = item.prod.indTot,
                            IDENTIFICACAO_nfe = idIdentificacaoNFe

                        });
                      
                    });

                }

            }
            else
            {
                // informar erro return null;
            }



            
        }

    }
}
