using System;
using System.Xml;
using System.Net;
using System.IO;

namespace Weblite_Api_Trial.Services
{
  public class SendEmailService : ISendService
  {
    public void Send()
    {
      var _url = "http://demomt.weblite.com.my/TS_Services/SubmissionsService.asmx";
      var _action = "";

      XmlDocument soapEnvelopeXml = CreateSoapEnvelope();
      HttpWebRequest webRequest = CreateWebRequest(_url, _action);
      InsertSoapEnvelopeIntoWebRequest(soapEnvelopeXml, webRequest);

      // begin async call to web request.
      IAsyncResult asyncResult = webRequest.BeginGetResponse(null, null);

      // suspend this thread until call is complete. You might want to
      // do something usefull here like update your UI.
      asyncResult.AsyncWaitHandle.WaitOne();

      // get the response from the completed web request.
      string soapResult;
      using (WebResponse webResponse = webRequest.EndGetResponse(asyncResult))
      {
        using (StreamReader rd = new StreamReader(webResponse.GetResponseStream()))
        {
          soapResult = rd.ReadToEnd();
        }
        Console.Write(soapResult);
      }

      throw new NotImplementedException();
    }

    private static HttpWebRequest CreateWebRequest(string url, string action)
    {
      HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(url);
      webRequest.Headers.Add("SOAPAction", action);
      webRequest.ContentType = "text/xml;charset=\"utf-8\"";
      webRequest.Accept = "text/xml";
      webRequest.Method = "POST";
      return webRequest;
    }

    private static XmlDocument CreateSoapEnvelope()
    {
      XmlDocument soapEnvelope = new XmlDocument();
      soapEnvelope.LoadXml("");
      return soapEnvelope;
    }

    private static void InsertSoapEnvelopeIntoWebRequest(XmlDocument soapEnvelopeXml, HttpWebRequest webRequest)
    {
      using (Stream stream = webRequest.GetRequestStream())
      {
        soapEnvelopeXml.Save(stream);
      }
    }
  }
}