using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace http.request
{
    public sealed class HttpRequest
    {

        public static string Get(string url)
        {
            return Get(url, ContentTypes.JSON);
        }

        public static string Get(string url, ContentTypes contentTypes)
        {
            return Get(url, null, contentTypes);
        }

        public static string Get(string url, string data)
        {
            return Get(url, data, ContentTypes.JSON);
        }

        public static string Get(string url, string data, ContentTypes contentTypes)
        {
            string method = "GET";
            return InnerHttp(url, data, method, contentTypes);
        }




        public static string Post(string url)
        {
            return Post(url, ContentTypes.JSON);
        }

        public static string Post(string url, ContentTypes contentTypes)
        {
            return Post(url, null, contentTypes);
        }

        public static string Post(string url, string data)
        {
            return Post(url, data, ContentTypes.JSON);
        }

        public static string Post(string url, string data, ContentTypes contentTypes)
        {
            string method = "POST";
            return InnerHttp(url, data, method, contentTypes);
        }

        /// <summary>
        /// 如果是以流的方式提交表单数据的时候不能使用get方法，必须用post方法.
        /// </summary>
        /// <param name="postUrl">提交的URL地址</param>
        /// <param name="postDatas">提交的数据</param>
        /// <param name="method">提交的HTTP的Method值</param>
        /// <returns></returns>
        private static string InnerHttp(string postUrl, string postDatas, string method , ContentTypes contentTypes)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(postUrl); //--需要封装的参数
            request.CookieContainer = new CookieContainer();
            CookieContainer cookie = request.CookieContainer;//如果用不到Cookie，删去即可
            //以下是发送的http头
            request.Referer = string.Empty;
            if (!string.IsNullOrEmpty(referer))
            {
                request.Referer = referer;
            }
            request.Accept = "Accept:text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
            if (!string.IsNullOrEmpty(accept))
            {
                request.Accept = accept;
            }
            request.Headers["Accept-Language"] = "zh-CN,zh;q=0.";
            request.Headers["Accept-Charset"] = "GBK,utf-8;q=0.7,*;q=0.3";
            foreach (string key in headers.Keys)
            {
                request.Headers.Set(key, headers[key]);
            }
            request.UserAgent = "User-Agent:Mozilla/5.0 (Windows NT 5.1) AppleWebKit/535.1 (KHTML, like Gecko) Chrome/14.0.835.202 Safari/535.1";
            if (!string.IsNullOrEmpty(userAgent))
            {
                request.UserAgent = userAgent;
            }
            request.KeepAlive = true;
            //上面的http头看情况而定，但是下面俩必须加
            request.ContentType = GetEnumDesc(contentTypes);
            Encoding encoding = Encoding.UTF8;//根据网站的编码自定义
            request.Method = method;  //--需要将get改为post才可行
            string postDataStr;
            Stream requestStream = request.GetRequestStream();
            if (postDatas != "" && postDatas != null)
            {
                postDataStr = postDatas;//--需要封装,形式如“arg=arg1&arg2=arg2”
                byte[] postData = encoding.GetBytes(postDataStr);//postDataStr即为发送的数据，
                request.ContentLength = postData.Length;
                requestStream.Write(postData, 0, postData.Length);
            }

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream responseStream = response.GetResponseStream();

            StreamReader streamReader = new StreamReader(responseStream, encoding);
            string retString = streamReader.ReadToEnd();

            streamReader.Close();
            responseStream.Close();
            return retString;
        }

        private static string GetEnumDesc(Enum e)
        {
            var enumInfo = e.GetType().GetField(e.ToString());
            var enumAttributes = (DescriptionAttribute[])enumInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);
            return enumAttributes.Length > 0 ? enumAttributes[0].Description : e.ToString();
        }

        private static IDictionary<string, string> headers = new Dictionary<string, string>();

        private static IDictionary<string, string> Headers
        {
            get { return headers; }
        }

        private static string accept = null;
        public static string Accept
        {
            get
            {

                return accept;
            }
            set
            {
                accept = value;
            }
        }

        private static string userAgent = null;
        public static string UserAgent
        {
            get
            {
                return userAgent;
            }
            set
            {
                userAgent = value;
            }
        }

        private static string referer = null;
        public static string Referer
        {
            get
            {
                return string.Empty;
            }
            set
            {
                referer = value;
            }
        }
    }
}
