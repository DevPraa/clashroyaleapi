using ClashRoyaleAPI.Exceptions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace ClashRoyaleAPI.BL
{
    public class Base
    {
        protected T ApiReqest <T>(string _Url, string ID, string Postfix=null)
        {
            try
            {
                var webRequest = System.Net.HttpWebRequest.Create(_Url + $"%23{ID.Replace("#", "")}"+ Postfix);//P2RQGRP9G
                if (webRequest != null)
                {
                    webRequest.Method = "GET";
                    webRequest.Timeout = 120000;
                    webRequest.ContentType = "application/json";
                    webRequest.Headers.Add("Authorization", $"Bearer {Core.Instance.Token}");
                    var webResponse = webRequest.GetResponse();
                    using (System.IO.Stream s = webResponse.GetResponseStream())
                    {
                        using (System.IO.StreamReader sr = new System.IO.StreamReader(s))
                        {
                            var jsonResponse = sr.ReadToEnd();
                            return JsonConvert.DeserializeObject<T>(jsonResponse);
                        }
                    }
                }
                return default(T);
            }
            catch (Exception ex)
            {
                string message = string.Empty;
                if (ex is WebException)
                {                    
                    int ErrorCode = (int)((((HttpWebResponse)((ex as WebException)?.Response))?.StatusCode) ?? HttpStatusCode.ExpectationFailed);
                    switch (ErrorCode)
                    {
                        case 400: message = "Client provided incorrect parameters for the request."; break;
                        case 403:
                            message = "Access denied, either because of missing/incorrect credentials or used API token does not grant access to the requested resource."; break;
                        case 404: message = "Resource was not found."; break;
                        case 429: message = "Request was throttled, because amount of requests was above the threshold defined for the used API token."; break;
                        case 500: message = "Unknown error happened when handling the request."; break;
                        case 503: message = "Service is temprorarily unavailable because of maintenance."; break;
                        case 417: throw ex;
                        default:
                            break;
                    }
                    throw new ClashRoyaleAPIException(message ?? ex.Message, ex);
                }
                else
                {
                    throw;
                }                
            }
        }

        protected T ApiReqest<T>(string _Url)
        {
            try
            {
                var webRequest = System.Net.HttpWebRequest.Create(_Url);
                if (webRequest != null)
                {
                    webRequest.Method = "GET";
                    webRequest.Timeout = 120000;
                    webRequest.ContentType = "application/json";
                    webRequest.Headers.Add("Authorization", $"Bearer {Core.Instance.Token}");
                    var webResponse = webRequest.GetResponse();
                    using (System.IO.Stream s = webResponse.GetResponseStream())
                    {
                        using (System.IO.StreamReader sr = new System.IO.StreamReader(s))
                        {
                            var jsonResponse = sr.ReadToEnd();
                            return JsonConvert.DeserializeObject<T>(jsonResponse);
                        }
                    }
                }
                return default(T);
            }
            catch (Exception ex)
            {
                string message = string.Empty;
                if (ex is WebException)
                {

                    int ErrorCode = (int)((HttpWebResponse)(ex as WebException).Response).StatusCode;
                    switch (ErrorCode)
                    {
                        case 400: message = "Client provided incorrect parameters for the request."; break;
                        case 403:
                            message = "Access denied, either because of missing/incorrect credentials or used API token does not grant access to the requested resource."; break;
                        case 404: message = "Resource was not found."; break;
                        case 429: message = "Request was throttled, because amount of requests was above the threshold defined for the used API token."; break;
                        case 500: message = "Unknown error happened when handling the request."; break;
                        case 503: message = "Service is temprorarily unavailable because of maintenance."; break;
                        default:
                            break;
                    }
                }
                throw new ClashRoyaleAPIException(message ?? ex.Message, ex);
            }
        }
    }
}
