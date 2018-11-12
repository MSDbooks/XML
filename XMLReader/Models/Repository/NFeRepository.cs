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

        public void insertNFe(DTO.RootObject nf)
        {
            int idIdentificacaoNFe;

            #region INSERT_EMITENTE
            var query = @"SELECT ID FROM EMITENTE 
                            WHERE CNPJ = @CNPJ";

            var idEmitente = GetConnection().Query<int>(query, new { CNPJ = nf.nfeProc.NFe.infNFe.emit.CNPJ }).FirstOrDefault();
            //se não existir emitente, inclui e retorna o id
            if (idEmitente == 0)
            {

                query = @"INSERT INTO  EMITENTE VALUES (
                              @CNPJ, @xNome, @xFant, @IE
                         )
                         SELECT SCOPE_IDENTITY()";

                idEmitente = GetConnection().Query<int>(query, new
                {
                    CNPJ = nf.nfeProc.NFe.infNFe.emit.CNPJ,
                    xNome = nf.nfeProc.NFe.infNFe.emit.xNome,
                    xFant = nf.nfeProc.NFe.infNFe.emit.xFant,
                    IE = nf.nfeProc.NFe.infNFe.emit.IE
                })
                .FirstOrDefault();
            }
            #endregion

            if (idEmitente != 0)
            {
                #region INSERT_NFE
                query = @"SELECT * FROM IDENTIFICACAO_NFE
                            WHERE EMITENTE = @EMITENTE";
                var infoNFE = GetConnection().Query<DTO.IDENTIFICACAO_nfe>(query, new { EMITENTE = idEmitente }).FirstOrDefault();

                if (infoNFE == null)
                {

                    query = @"INSERT INTO  IDENTIFICACAO_nfe VALUES (
                                 @cUF, @cNF, @natOp, @nNF, @dhEmi, @EMITENTE
                             )
                             SELECT SCOPE_IDENTITY()";

                    idIdentificacaoNFe = GetConnection().Query<int>(query, new
                    {
                        cUF = long.Parse(nf.nfeProc.NFe.infNFe.ide.cUF),
                        cNF = nf.nfeProc.NFe.infNFe.ide.cNF,
                        natOp = nf.nfeProc.NFe.infNFe.ide.natOp,
                        nNF = long.Parse(nf.nfeProc.NFe.infNFe.ide.nNF),
                        dhEmi = DateTime.Now,
                        EMITENTE = idEmitente

                    })
                    .FirstOrDefault();
                }
                else
                {
                    idIdentificacaoNFe = infoNFE.ID;
                }
                #endregion

                if (idIdentificacaoNFe != 0)
                {



                    #region INSERT PRODUTOS
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
                    
                    nf.nfeProc.NFe.infNFe.det.ForEach(item =>
                    {

                    string qrd = @"SELECT ID FROM PRODUTO
                                         WHERE XPROD = @XPROD AND CPROD = @CPROD AND VPROD = @VPROD AND QTRIB = @QTRIB ";

                    var itemExistente = GetConnection().Query<int>(qrd, 
                        new {
                                XPROD = item.prod.xProd, CPROD = item.prod.cProd, VPROD = item.prod.vProd, QTRIB = item.prod.qTrib
                            }).FirstOrDefault();

                    if (itemExistente == 0)
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
                                qCom = item.prod.qCom,
                                vUnCom = item.prod.vUnCom,
                                vProd = item.prod.vProd,
                                cEANTrib = item.prod.cEANTrib,
                                uTrib = item.prod.uTrib,
                                qTrib = item.prod.qTrib,
                                vUnTrib = item.prod.vUnTrib,
                                indTot = item.prod.indTot,
                                IDENTIFICACAO_nfe = idIdentificacaoNFe

                            });
                        }

                    });
                    #endregion

                }
                else
                {
                    //TRATAR ERRO QDO NÃO TEM ID DA NF
                }

            }
            else
            {
                //TRATAR ERRO QUANDO NÃO TEM EMITENTE
            }



            
        }

    }
}
