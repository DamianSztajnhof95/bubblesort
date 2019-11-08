using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSortClient
{
    public enum httpVerb
    {
        GET,
        POST,
        PUT,
        DELETE
    }
    class RestClass
    {
        
        public string endPoint { get; set; }
        public httpVerb httpMethod { get; set; }
        public RestClass()
        {
            endPoint = string.Empty;
            httpMethod = httpVerb.GET;
        }
        public string makeRequest()
        {
            string strResonseValue = string.Empty;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(endPoint);
             request.Method = httpMethod.ToString();
            using(HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                if(response.StatusCode!= HttpStatusCode.OK)
                {
                    throw new ApplicationException("error");
                }
                using (Stream responseStream = response.GetResponseStream())
                {
                    if (responseStream != null)
                    {
                        using(StreamReader reader = new StreamReader(responseStream))
                        {
                            strResonseValue = reader.ReadToEnd();
                        }
                    }
                }
            }
            return strResonseValue;
        }
        
            
               

            
        
    }
}
