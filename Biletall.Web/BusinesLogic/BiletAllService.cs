using Biletall.Web.Models;
using ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;

namespace Biletall.Web.BusinesLogic
{
    public class BiletAllService
    {
        public static List<KaraNokta> KaraNoktalariGetir()
        {

            XmlIsletRequestBody xirb = new XmlIsletRequestBody();
            XmlDocument xml = new XmlDocument();
            xml.LoadXml("<Kullanici><Adi>" + "stajyerWS" + "</Adi><Sifre>" + "2324423WSs099"
+ "</Sifre></Kullanici>");
            xirb.xmlYetki = xml.DocumentElement;

            XmlDocument xml2 = new XmlDocument();
            xml2.LoadXml(@"<KaraNoktaGetirKomut/>");
            xirb.xmlIslem = xml2.DocumentElement;

            var xx = new XmlIsletRequest(xirb);

            var service = new ServiceSoapClient(ServiceSoapClient.EndpointConfiguration.ServiceSoap).XmlIslet(xirb.xmlIslem, xirb.xmlYetki);

            List<KaraNokta> list = new List<KaraNokta>();

            XmlNodeList xnList = service.SelectNodes("/KaraNokta");
            foreach (XmlNode xn in xnList)
            {
                KaraNokta kn = new KaraNokta
                {
                    ID = xn["ID"].InnerText,
                    Ad = xn["Ad"].InnerText,
                    Aciklama = xn["Aciklama"].InnerText,
                    BagliOlduguNoktaID = xn["BagliOlduguNoktaID"].InnerText,
                    Bolge = xn["Bolge"].InnerText,
                    MerkezMi = xn["MerkezMi"].InnerText,
                    SeyahatSehirID = xn["SeyahatSehirID"].InnerText
                };
                if (kn.MerkezMi == "1")
                {
                    list.Add(kn);
                }

            }
            return list;
        }
        public static List<Sefer> SeferleriGetir(string nereden, string nereye, DateTime tarih)
        {
            XmlIsletRequestBody xirb = new XmlIsletRequestBody();
            XmlDocument xml = new XmlDocument();
            xml.LoadXml("<Kullanici><Adi>" + "stajyerWS" + "</Adi><Sifre>" + "2324423WSs099"
+ "</Sifre></Kullanici>");
            xirb.xmlYetki = xml.DocumentElement;

            XmlDocument xml2 = new XmlDocument();
            xml2.LoadXml(@"<Sefer><FirmaNo>0</FirmaNo><KalkisNoktaID>" + nereden + "</KalkisNoktaID><VarisNoktaID>" + nereye +
                "</VarisNoktaID><Tarih>" + tarih.ToString("yyyy-MM-dd") + "</Tarih><AraNoktaGelsin>1</AraNoktaGelsin><IslemTipi>0</IslemTipi><YolcuSayisi>1</YolcuSayisi><Ip>127.0.0.1</Ip></Sefer>");


            xirb.xmlIslem = xml2.DocumentElement;

            var xx = new XmlIsletRequest(xirb);
            List<Sefer> list = new List<Sefer>();

            var service = new ServiceSoapClient(ServiceSoapClient.EndpointConfiguration.ServiceSoap).XmlIslet(xirb.xmlIslem, xirb.xmlYetki);
            try
            {


                XmlNodeList xnList = service.SelectNodes("/Table");
                foreach (XmlNode xn in xnList)
                {
                    Sefer sfr = new Sefer
                    {
                        ID = xn["ID"].InnerText,
                        BiletFiyati1 = Convert.ToInt32(xn["BiletFiyati1"].InnerText),
                        BiletFiyatiInternet = Convert.ToInt32(xn["BiletFiyatiInternet"].InnerText),
                        FirmaAdi = xn["FirmaAdi"].InnerText,
                        KalkisNokta = xn["KalkisNokta"].InnerText,
                        OTipOzellik = xn["OTipOzellik"].InnerText,
                        VarisNokta = xn["VarisNokta"].InnerText,
                        YaklasikSeyahatSuresi = xn["YaklasikSeyahatSuresi"].InnerText,
                        OtobusKoltukYerlesimTipi = xn["OtobusKoltukYerlesimTipi"].InnerText,

                        SeferTakipNo = xn["SeferTakipNo"].InnerText,
                    };
                    sfr.Guzergahlar = GuzergahlariGetir(nereden, nereye, tarih, sfr.SeferTakipNo);
                    DateTime ss;
                    sfr.KalkisSaati = DateTime.TryParse(xn["Saat"].InnerText, out ss) ? ss.Hour.ToString() + ":" + ss.Minute.ToString("00") : "";


                    list.Add(sfr);
                }
                return list;
            }
            catch (Exception)
            {

                var sonuc = ((System.Xml.XmlCharacterData)service.SelectNodes("/Sonuc")[0].FirstChild).Data.ToString() != "false";
                return list;
            }

        }

        public static List<Guzergah> GuzergahlariGetir(string nereden, string nereye, DateTime tarih, string seferTakipNo)
        {

            XmlIsletRequestBody xirb = new XmlIsletRequestBody();
            XmlDocument xml = new XmlDocument();
            xml.LoadXml("<Kullanici><Adi>" + "stajyerWS" + "</Adi><Sifre>" + "2324423WSs099"
+ "</Sifre></Kullanici>");
            xirb.xmlYetki = xml.DocumentElement;

            XmlDocument xml2 = new XmlDocument();
            xml2.LoadXml(@"<Hat><FirmaNo>37</FirmaNo><HatNo>1</HatNo><KalkisNoktaID>" + nereden + "</KalkisNoktaID><VarisNoktaID>" + nereye + "</VarisNoktaID><BilgiIslemAdi>GuzergahVerSaatli</BilgiIslemAdi>" +
                "<SeferTakipNo>" + seferTakipNo + "</SeferTakipNo><Tarih>" + tarih.ToString("yyyy-MM-dd") + "</Tarih></Hat>");

            xirb.xmlIslem = xml2.DocumentElement;

            var xx = new XmlIsletRequest(xirb);
            List<Guzergah> list = new List<Guzergah>();

            var service = new ServiceSoapClient(ServiceSoapClient.EndpointConfiguration.ServiceSoap).XmlIslet(xirb.xmlIslem, xirb.xmlYetki);
            try
            {


                XmlNodeList xnList = service.SelectNodes("/Table1");
                foreach (XmlNode xn in xnList)
                {
                    Guzergah sfr = new Guzergah
                    {
                        VarisYeri = xn["VarisYeri"].InnerText,
                        SiraNo = xn["SiraNo"].InnerText,
                        //KalkisTarihSaat = xn["KalkisTarihSaat"].InnerText,
                        //VarisTarihSaat = xn["VarisTarihSaat"].InnerText,
                        KaraNoktaID = xn["KaraNoktaID"].InnerText,
                        KaraNoktaAd = xn["KaraNoktaAd"].InnerText
                    };
                    DateTime kts, vts;
                    sfr.KalkisTarihSaat = DateTime.TryParse(xn["KalkisTarihSaat"].InnerText, out kts) ? kts.Hour.ToString() + ":" + kts.Minute.ToString("00") : "";
                    sfr.VarisTarihSaat = DateTime.TryParse(xn["VarisTarihSaat"].InnerText, out vts) ? vts.Hour.ToString() + ":" + vts.Minute.ToString("00") : "";

                    list.Add(sfr);
                }
                return list;
            }
            catch (Exception)
            {
                return list;
            }

        }
       
        public static List<Koltuk> KoltukBilgisiAl(string seferReferans)
        {
            List<Koltuk> koltuklar = new List<Koltuk>();
            XmlIsletRequestBody isletRequestBody = new XmlIsletRequestBody();
            XmlDocument xml = new XmlDocument();
            xml.LoadXml("<Kullanici><Adi>stajyerWS</Adi><Sifre>2324423WSs099</Sifre></Kullanici>");
            isletRequestBody.xmlYetki = xml.DocumentElement;

            XmlDocument requestXml = new XmlDocument();
            requestXml.LoadXml(@"<Otobus>
                                     <FirmaNo>0</FirmaNo>
                                     <KalkisNoktaID>738</KalkisNoktaID>
                                     <VarisNoktaID>84</VarisNoktaID>
                                     <Tarih>2018-12-09</Tarih>
                                     <Saat>1900-01-01T02:30:00+02:00</Saat>
                                     <HatNo>1</HatNo>
                                     <IslemTipi>0</IslemTipi>
                                     <SeferTakipNo>" + seferReferans + @"</SeferTakipNo>
                                     <Ip>127.0.0.1</Ip>
                                  </Otobus>");
            isletRequestBody.xmlIslem = requestXml.DocumentElement;

            var service = new ServiceSoapClient(ServiceSoapClient.EndpointConfiguration.ServiceSoap)
                .XmlIslet(isletRequestBody.xmlIslem, isletRequestBody.xmlYetki);
            XmlNodeList nodeKoltukList = service.SelectNodes("/Koltuk");
            foreach (XmlNode nodeKoltuk in nodeKoltukList)
            {
                koltuklar.Add(new Koltuk
                {
                    KoltukStr = nodeKoltuk["KoltukStr"].InnerText,
                    KoltukNo = nodeKoltuk["KoltukNo"].InnerText,
                    Durum = nodeKoltuk["Durum"].InnerText,
                    DurumYan = nodeKoltuk["DurumYan"].InnerText,
                    KoltukFiyatiInternet = nodeKoltuk["KoltukFiyatiInternet"].InnerText
                });
            }
            return koltuklar;
        }


    }
}
