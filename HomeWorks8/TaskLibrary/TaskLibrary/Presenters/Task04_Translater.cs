using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Web;

namespace TaskLibrary
{
  public  class Task04_Translater
    {
        public String Translate(String word)
        {
            var toLanguage = "ru";
            var fromLanguage = "en";
            var url = $"https://translate.googleapis.com/translate_a/single?client=gtx&sl={fromLanguage}&tl={toLanguage}&dt=t&q={HttpUtility.UrlEncode(word)}";
            var webClient = new WebClient
            {
                Encoding = System.Text.Encoding.UTF8
            };
            var result = webClient.DownloadString(url);
            try
            {
                result = result.Substring(4, result.IndexOf("\"", 4, StringComparison.Ordinal) - 4);
                return result;
            }
            catch
            {
                return "Error";
            }
        }

    }
}
