using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace GCMSTests
{
    [Serializable]
    public class PmanActionRecord {


        public DateTime Date { get; set; }
        public string Url { get; set; }
        public string Method { get; set; }
        public string Status { get; set; }
        public Dictionary<string, string> Headers { get; set; }
        public string Body { get; set; }
        public string Response { get; set; }
        public int Ordinal { get; set; }


        public PmanActionRecord() {
            this.Headers = new Dictionary<string, string>();
        }

    }

    static public class Pman
    {


        static int _ord = 0;
        static public event EventHandler RequestSend;
        static public event EventHandler ResponseRecieve;
        static public event EventHandler Error;
        static public event EventHandler SendData;

        static DateTime LgenDate = DateTime.Now.AddDays(-1);
        static public string BaseUrl { get; set; }
        static public string Username { get; set; }
        static public string Password { get; set; }
        static public string LastHash { get; set; }

        static  void OnError(EventArgs e, object sender)
        {
            if (Error != null)
                Error(sender, e);
        }

        static void OnRequestSend(EventArgs e, object sender)
        {
            if (RequestSend != null)
                RequestSend(sender, e);
        }

        static void OnResponseRecieve(EventArgs e, object sender)
        {
            if (ResponseRecieve != null)
                ResponseRecieve(sender, e);
        }


        static void OnSendData(EventArgs e, object sender)
        {
            if (SendData != null)
                SendData(sender, e);
        }


        static public  string Get(string url, string method, string body)
        {
            _ord++;
            StringBuilder lup = new StringBuilder();
            StringBuilder ldwn = new StringBuilder();
            PmanActionRecord pmar = new PmanActionRecord() { Date = DateTime.Now, Body = body, Url = BaseUrl + url, Method = method, Ordinal = _ord };
            try
            {
                

                
               lup.AppendLine(method+"\\");
                pmar.Headers.Add("accept", "application/json;charset=utf-8");
                lup.AppendLine("-H 'accept: application/json;charset=utf-8' \\");
                System.Net.WebRequest req = System.Net.WebRequest.Create(BaseUrl + url);
                
                req.Method = method;
                req.Timeout = 1000 * 3600;
                ((System.Net.HttpWebRequest)req).Accept = "application/json;charset=utf-8";
                if (method == "POST" || method == "PUT")
                {
                    req.ContentType = "application/json";
                    req.ContentLength = body.Length;
                    lup.AppendLine("-H 'content-type: application/json' \\");
                    lup.AppendLine("-H 'content-lenght: "+body.Length.ToString()+"' \\");
                    pmar.Headers.Add("content-type", "application/json");
                    pmar.Headers.Add("content-lenght", body.Length.ToString());
                    System.IO.StreamWriter stOut = new System.IO.StreamWriter(req.GetRequestStream(), System.Text.Encoding.Default);
                    stOut.Write(body);
                    stOut.Close();
                    lup.AppendLine("'" + BaseUrl + url + "'");
                    lup.AppendLine(body);
                }
                else
                {
                    lup.AppendLine("'" +BaseUrl+ url + "'");
                }
                OnRequestSend(EventArgs.Empty, lup.ToString());
                System.IO.StreamReader stIn = new System.IO.StreamReader(req.GetResponse().GetResponseStream());
                string strResponse = stIn.ReadToEnd();
                stIn.Close();
                               
                

                ldwn.AppendLine(strResponse);
                OnResponseRecieve(EventArgs.Empty, ldwn.ToString());

                pmar.Response = strResponse;
                pmar.Status = "200 ok";
                OnSendData(EventArgs.Empty, pmar);
                return strResponse;
            }
            catch (System.Net.WebException exx)
            {
                using (System.Net.WebResponse response = exx.Response)
                {
                    
                     
                    System.Net.HttpWebResponse httpResponse = (System.Net.HttpWebResponse)response;
                    string t = string.Empty;
                       
                    using (System.IO.Stream data = response.GetResponseStream())
                    {
                        t = new System.IO.StreamReader(data).ReadToEnd();

                    }
                    ldwn.Append("Status code: " +exx.Status.ToString());
                    ldwn.Append(t);
                    OnResponseRecieve(EventArgs.Empty, ldwn.ToString());
                    OnError(EventArgs.Empty, t);

                    pmar.Response = t;
                    pmar.Status = exx.Status.ToString();
                    OnSendData(EventArgs.Empty, pmar);
                    return t;
                }
            }
        }



        static public string GenerateNewHash() {
            if (DateTime.Now.Subtract(LgenDate).TotalMinutes <= 30 && LastHash != string.Empty)
                return LastHash;

            LastHash = string.Empty;
            try
            {
                

                string resultDataAuth = Pman.Get("Auth/?username=" + Username + "&password=" + Password, "GET", string.Empty);

                Classes.Result resAuth = Classes.Result.Parse(resultDataAuth);
                /* si hay un error, corto */
                if (resAuth.status != "0")
                {

                    OnError(EventArgs.Empty, resAuth.status+" - "+ resAuth.message);
                    return string.Empty;
                }
                LastHash = resAuth.data;
                LgenDate = DateTime.Now;
                return resAuth.data;
                

            }
            catch { }
            return string.Empty;
        }
      

        static public string Connect(string burl, string username, string password) {

            BaseUrl = burl;
            Username = username;
            Password = password;
            return GenerateNewHash();

        }



    }
}
