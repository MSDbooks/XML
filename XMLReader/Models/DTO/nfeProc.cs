using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace XMLReader.Models.DTO
{
    //verificado
    //public class ide
    //{
    //    public string cUF { get; set; }
    //    public string cNF { get; set; }
    //    public string natOp { get; set; }
    //    public string indPag { get; set; }
    //    public string mod { get; set; }
    //    public string serie { get; set; }
    //    public string nNF { get; set; }
    //    public DateTime dhEmi { get; set; }
    //    public DateTime dhSaiEnt { get; set; }
    //    public string tpNF { get; set; }
    //    public string idDest { get; set; }
    //    public string cMunFG { get; set; }
    //    public string tpImp { get; set; }
    //    public string tpEmis { get; set; }
    //    public string cDV { get; set; }
    //    public string tpAmb { get; set; }
    //    public string finNFe { get; set; }
    //    public string indFinal { get; set; }
    //    public string indPres { get; set; }
    //    public string procEmi { get; set; }
    //    public string verProc { get; set; }
    //}
    ////verificado
    //public class enderEmit
    //{
    //    public string xLgr { get; set; }
    //    public string nro { get; set; }
    //    public string xBairro { get; set; }
    //    public string cMun { get; set; }
    //    public string xMun { get; set; }
    //    public string UF { get; set; }
    //    public string CEP { get; set; }
    //    public string cPais { get; set; }
    //    public string xPais { get; set; }
    //    public string fone { get; set; }
    //}
    ////verificado
    //public class emit
    //{

    //    public string CNPJ { get; set; }
    //    public string xNome { get; set; }
    //    public string xFant { get; set; }
    //    public enderEmit enderEmit { get; set; }
    //    public string IE { get; set; }
    //    public string CRT { get; set; }
    //}
    ////verificado
    //public class enderDest
    //{
    //    public string xLgr { get; set; }
    //    public string nro { get; set; }
    //    public string xBairro { get; set; }
    //    public string cMun { get; set; }
    //    public string xMun { get; set; }
    //    public string UF { get; set; }
    //    public string CEP { get; set; }
    //    public string cPais { get; set; }
    //    public string xPais { get; set; }
    //    public string fone { get; set; }
    //}
    ////verificado
    //public class dest
    //{
    //    public string CNPJ { get; set; }
    //    public string xNome { get; set; }
    //    public enderDest enderDest { get; set; }
    //    public string indIEDest { get; set; }
    //    public string IE { get; set; }
    //    public string email { get; set; }
    //}
    ////verificado
    //public class prod
    //{
    //    public string cProd { get; set; }
    //    public string cEAN { get; set; }
    //    public string xProd { get; set; }
    //    public string NCM { get; set; }
    //    public string CEST { get; set; }
    //    public string CFOP { get; set; }
    //    public string uCom { get; set; }
    //    public string qCom { get; set; }
    //    public string vUnCom { get; set; }
    //    public string vProd { get; set; }
    //    public string cEANTrib { get; set; }
    //    public string uTrib { get; set; }
    //    public string qTrib { get; set; }
    //    public string vUnTrib { get; set; }
    //    public string indTot { get; set; }

    //}

    //public class ICMS00
    //{
    //    public string orig { get; set; }
    //    public string CST { get; set; }
    //    public string modBC { get; set; }
    //    public string vBC { get; set; }
    //    public string pICMS { get; set; }
    //    public string vICMS { get; set; }
    //}

    //public class ICMS20
    //{
    //    public string orig { get; set; }
    //    public string CST { get; set; }
    //    public string modBC { get; set; }
    //    public string pRedBC { get; set; }
    //    public string vBC { get; set; }
    //    public string pICMS { get; set; }
    //    public string vICMS { get; set; }
    //}

    //public class ICMS60
    //{
    //    public string orig { get; set; }
    //    public string CST { get; set; }
    //}

    //public class ICMS40
    //{
    //    public string orig { get; set; }
    //    public string CST { get; set; }
    //}
    ////verificado
    //public class ICMSSN102
    //{
    //    public string orig { get; set; }
    //    public string CSOSN { get; set; }
    //}
    ////verificado
    //public class ICMS
    //{
    //    public ICMSSN102 ICMSSN102 { get; set; }
    //}
    ////verificado
    //public class IPINT
    //{
    //    public string CST { get; set; }
    //}
    ////verificado
    //public class IPI
    //{
    //    public string cEnq { get; set; }
    //    public IPINT IPINT { get; set; }
    //}

    //public class PISAliq
    //{
    //    public string CST { get; set; }
    //    public string vBC { get; set; }
    //    public string pPIS { get; set; }
    //    public string vPIS { get; set; }
    //}

    //public class PISNT
    //{
    //    public string CST { get; set; }
    //}
    ////verificado
    //public class PIS
    //{
    //    public PISNT PISNT { get; set; }
    //}
    ////verificado
    //public class COFINSAliq
    //{
    //    public string CST { get; set; }
    //    public string vBC { get; set; }
    //    public string pCOFINS { get; set; }
    //    public string vCOFINS { get; set; }
    //}
    ////verificado
    //public class COFINSNT
    //{
    //    public string CST { get; set; }
    //}
    ////verificado
    //public class COFINS
    //{
    //    public COFINSNT COFINSNT { get; set; }
    //}
    ////verificado
    //public class imposto
    //{
    //    public ICMS ICMS { get; set; }
    //    public IPI IPI { get; set; }
    //    public PIS PIS { get; set; }
    //    public COFINS COFINS { get; set; }
    //}
    ////verificado
    
    //public class det
    //{
    //    public prod prod { get; set; }
    //    public imposto imposto { get; set; }
    //}
    ////verificado
    //public class ICMSTot
    //{
    //    public string vBC { get; set; }
    //    public string vICMS { get; set; }
    //    public string vICMSDeson { get; set; }
    //    public string vBCST { get; set; }
    //    public string vST { get; set; }
    //    public string vProd { get; set; }
    //    public string vFrete { get; set; }
    //    public string vSeg { get; set; }
    //    public string vDesc { get; set; }
    //    public string vII { get; set; }
    //    public string vIPI { get; set; }
    //    public string vPIS { get; set; }
    //    public string vCOFINS { get; set; }
    //    public string vOutro { get; set; }
    //    public string vNF { get; set; }
    //}
    ////verificado
    //public class total
    //{
    //    public ICMSTot ICMSTot { get; set; }
    //}
    ////verificado
    //public class vol
    //{
    //    public string qVol { get; set; }
    //    public string esp { get; set; }
    //    public string pesoL { get; set; }
    //    public string pesoB { get; set; }
    //}
    ////verificado
    //public class transp
    //{
    //    public string modFrete { get; set; }
    //    public vol vol { get; set; }
    //}
    ////verificado
    //public class fat
    //{
    //    public string nFat { get; set; }
    //    public string vOrig { get; set; }
    //    public string vLiq { get; set; }
    //}
    ////verificado
    //public class dup
    //{
    //    public string nDup { get; set; }
    //    public string dVenc { get; set; }
    //    public string vDup { get; set; }
    //}
    ////verificado
    //public class cobr
    //{
    //    public fat fat { get; set; }
    //    public dup dup { get; set; }
    //}
    ////verificado
    //public class infAdic
    //{
    //    public string infCpl { get; set; }
    //}
    ////verificado
    //public class infNFe
    //{
    //    public ide ide { get; set; }
    //    public emit emit { get; set; }
    //    public dest dest { get; set; }
    //    public List<det> det { get; set; }
    //    public total total { get; set; }
    //    public transp transp { get; set; }
    //    public cobr cobr { get; set; }
    //    public infAdic infAdic { get; set; }
    //}
    ////verificado 
    //public class CanonicalizationMethod
    //{
    //    [JsonProperty("@Algorithm")]
    //    public string AlgorithmCanonicalizationMethod { get; set; }
    //}
    ////verificado
    //public class SignatureMethod
    //{
    //    [JsonProperty("@Algorithm")]
    //    public string AlgorithmSignatureMethod { get; set; }
    //}
    ////verificado
    //public class Transform
    //{
    //    [JsonProperty("@Algorithm")]
    //    public string AlgorithmTransform { get; set; }
    //}
    ////não usado
    //public class Transforms
    //{
    //    public List<Transform> Transform { get; set; }
    //}
    ////verificado
    //public class DigestMethod
    //{
    //    [JsonProperty("@Algorithm")]
    //    public string AlgorithmDigestMethod { get; set; }
    //}
    ////verificado
    //public class Reference
    //{
    //    public Transforms Transforms { get; set; }
    //    public DigestMethod DigestMethod { get; set; }
    //    public string DigestValue { get; set; }
    //}
    ////verificado
    //public class SignedInfo
    //{
    //    public CanonicalizationMethod CanonicalizationMethod { get; set; }
    //    public SignatureMethod SignatureMethod { get; set; }
    //    public Reference Reference { get; set; }
    //}
    ////verificado
    //public class X509Data
    //{
    //    public string X509Certificate { get; set; }
    //}
    ////verificado
    //public class KeyInfo
    //{
    //    public X509Data X509Data { get; set; }
    //}

    //public class Signature
    //{
    //    public SignedInfo SignedInfo { get; set; }
    //    public string SignatureValue { get; set; }
    //    public KeyInfo KeyInfo { get; set; } //verificado
    //}

    //public class NFe
    //{
    //    public infNFe infNFe { get; set; }
    //    public Signature Signature { get; set; } //VERIFICADO
    //}
    ////verificado
    //public class infProt
    //{
    //    public string tpAmb { get; set; }
    //    public string verAplic { get; set; }
    //    public string chNFe { get; set; }
    //    public DateTime dhRecbto { get; set; }
    //    public string nProt { get; set; }
    //    public string digVal { get; set; }
    //    public string cStat { get; set; }
    //    public string xMotivo { get; set; }
    //}
    ////Verificado
    //public class protNFe
    //{
    //    public infProt infProt { get; set; }
    //}


    //public class nfeProc
    //{

    //    public NFe NFe { get; set; }
    //    public protNFe protNFe { get; set; } //verificado

    //}

   

}