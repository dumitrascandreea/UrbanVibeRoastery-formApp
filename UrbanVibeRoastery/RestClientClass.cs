using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace UrbanVibeRoastery
{
    public enum httpVerb
    {
        GET,
        POST,
        PUT,
        DELETE
    }
    class RestClientClass
    {
        public string endpoint { get; set; }
        public httpVerb httpMethod { get; set; }   
        public RestClientClass()
        {
            endpoint = string.Empty;
            httpMethod = httpVerb.GET;
        }
        public string makeRequest()
        {
            string strResponse = string.Empty;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(endpoint);
            request.Method = httpMethod.ToString();
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                if( response.StatusCode != HttpStatusCode.OK)
                {
                    throw new ApplicationException("eror code : " + response.StatusCode.ToString());
                }
                using (Stream responseStream = response.GetResponseStream())
                {
                    if(response != null)
                    {
                        using (StreamReader reader = new StreamReader(responseStream))
                        {
                            strResponse = reader.ReadToEnd();
                        }
                    }
                }
            }
            return strResponse;
        }
    }
}
