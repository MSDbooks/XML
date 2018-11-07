using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLReader.Models.DTO
{
    public class Ide
    {
        public string cUF { get; set; }
        public string cNF { get; set; }
        public string natOp { get; set; }
        public string indPag { get; set; }
        public string mod { get; set; }
        public string serie { get; set; }
        public string nNF { get; set; }
        public DateTime dhEmi { get; set; }
        public string tpNF { get; set; }
        public string idDest { get; set; }
        public string cMunFG { get; set; }
        public string tpImp { get; set; }
        public string tpEmis { get; set; }
        public string cDV { get; set; }
        public string tpAmb { get; set; }
        public string finNFe { get; set; }
        public string indFinal { get; set; }
        public string indPres { get; set; }
        public string procEmi { get; set; }
        public string verProc { get; set; }
    }

    public class EnderEmit
    {
        public string xLgr { get; set; }
        public string nro { get; set; }
        public string xBairro { get; set; }
        public string cMun { get; set; }
        public string xMun { get; set; }
        public string UF { get; set; }
        public string CEP { get; set; }
        public string cPais { get; set; }
        public string xPais { get; set; }
        public string fone { get; set; }
    }

    public class Emit
    {
        public string CNPJ { get; set; }
        public string xNome { get; set; }
        public string xFant { get; set; }
        public EnderEmit enderEmit { get; set; }
        public string IE { get; set; }
        public string CRT { get; set; }
    }

    public class EnderDest
    {
        public string xLgr { get; set; }
        public string nro { get; set; }
        public string xBairro { get; set; }
        public string cMun { get; set; }
        public string xMun { get; set; }
        public string UF { get; set; }
        public string CEP { get; set; }
        public string cPais { get; set; }
        public string xPais { get; set; }
        public string fone { get; set; }
    }

    public class Dest
    {
        public string CNPJ { get; set; }
        public string xNome { get; set; }
        public EnderDest enderDest { get; set; }
        public string indIEDest { get; set; }
        public string IE { get; set; }
        public string email { get; set; }
    }

    public class Prod
    {
        public string cProd { get; set; }
        public string cEAN { get; set; }
        public string xProd { get; set; }
        public string NCM { get; set; }
        public string CEST { get; set; }
        public string CFOP { get; set; }
        public string uCom { get; set; }
        public string qCom { get; set; }
        public string vUnCom { get; set; }
        public string vProd { get; set; }
        public string cEANTrib { get; set; }
        public string uTrib { get; set; }
        public string qTrib { get; set; }
        public string vUnTrib { get; set; }
        public string indTot { get; set; }
    }

    public class ICMSSN102
    {
        public string orig { get; set; }
        public string CSOSN { get; set; }
    }

    public class ICMS
    {
        public ICMSSN102 ICMSSN102 { get; set; }
    }

    public class IPINT
    {
        public string CST { get; set; }
    }

    public class IPI
    {
        public string cEnq { get; set; }
        public IPINT IPINT { get; set; }
    }

    public class PISNT
    {
        public string CST { get; set; }
    }

    public class PIS
    {
        public PISNT PISNT { get; set; }
    }

    public class COFINSNT
    {
        public string CST { get; set; }
    }

    public class COFINS
    {
        public COFINSNT COFINSNT { get; set; }
    }

    public class Imposto
    {
        public ICMS ICMS { get; set; }
        public IPI IPI { get; set; }
        public PIS PIS { get; set; }
        public COFINS COFINS { get; set; }
    }

    public class Det
    {
        public Prod prod { get; set; }
        public Imposto imposto { get; set; }
    }

    public class ICMSTot
    {
        public string vBC { get; set; }
        public string vICMS { get; set; }
        public string vICMSDeson { get; set; }
        public string vBCST { get; set; }
        public string vST { get; set; }
        public string vProd { get; set; }
        public string vFrete { get; set; }
        public string vSeg { get; set; }
        public string vDesc { get; set; }
        public string vII { get; set; }
        public string vIPI { get; set; }
        public string vPIS { get; set; }
        public string vCOFINS { get; set; }
        public string vOutro { get; set; }
        public string vNF { get; set; }
    }

    public class Total
    {
        public ICMSTot ICMSTot { get; set; }
    }

    public class Vol
    {
        public string qVol { get; set; }
        public string esp { get; set; }
        public string pesoL { get; set; }
        public string pesoB { get; set; }
    }

    public class Transp
    {
        public string modFrete { get; set; }
        public Vol vol { get; set; }
    }

    public class Fat
    {
        public string nFat { get; set; }
        public string vOrig { get; set; }
        public string vLiq { get; set; }
    }

    public class Dup
    {
        public string nDup { get; set; }
        public string dVenc { get; set; }
        public string vDup { get; set; }
    }

    public class Cobr
    {
        public Fat fat { get; set; }
        public Dup dup { get; set; }
    }

    public class InfAdic
    {
        public string infCpl { get; set; }
    }

    public class InfNFe
    {
        public Ide ide { get; set; }
        public Emit emit { get; set; }
        public Dest dest { get; set; }
        public List<Det> det { get; set; }
        public Total total { get; set; }
        public Transp transp { get; set; }
        public Cobr cobr { get; set; }
        public InfAdic infAdic { get; set; }
    }

    public class CanonicalizationMethod
    {
        [JsonProperty("@Algorithm")]
        public string Algorithm { get; set; }
    }

    public class SignatureMethod
    {
        [JsonProperty("@Algorithm")]
        public string Algorithm { get; set; }
    }

    public class Transform
    {
        [JsonProperty("@Algorithm")]
        public string Algorithm { get; set; }
    }

    public class Transforms
    {
        public List<Transform> Transform { get; set; }
    }

    public class DigestMethod
    {
        [JsonProperty("@Algorithm")]
        public string Algorithm { get; set; }
    }

    public class Reference
    {
        public Transforms Transforms { get; set; }
        public DigestMethod DigestMethod { get; set; }
        public string DigestValue { get; set; }
    }

    public class SignedInfo
    {
        public CanonicalizationMethod CanonicalizationMethod { get; set; }
        public SignatureMethod SignatureMethod { get; set; }
        public Reference Reference { get; set; }
    }

    public class X509Data
    {
        public string X509Certificate { get; set; }
    }

    public class KeyInfo
    {
        public X509Data X509Data { get; set; }
    }

    public class Signature
    {
        public SignedInfo SignedInfo { get; set; }
        public string SignatureValue { get; set; }
        public KeyInfo KeyInfo { get; set; }
    }

    public class NFe
    {
        public InfNFe infNFe { get; set; }
        public Signature Signature { get; set; }
    }

    public class InfProt
    {
        public string tpAmb { get; set; }
        public string verAplic { get; set; }
        public string chNFe { get; set; }
        public DateTime dhRecbto { get; set; }
        public string nProt { get; set; }
        public string digVal { get; set; }
        public string cStat { get; set; }
        public string xMotivo { get; set; }
    }

    public class ProtNFe
    {
        public InfProt infProt { get; set; }
    }

    public class NfeProc
    {
        public NFe NFe { get; set; }
        public ProtNFe protNFe { get; set; }
    }

    public class RootObject
    {
        public NfeProc nfeProc { get; set; }
    }
}
