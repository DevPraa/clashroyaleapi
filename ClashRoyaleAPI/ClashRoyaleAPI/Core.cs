using ClashRoyaleAPI.Enums;
using ClashRoyaleAPI.Exceptions;
using ClashRoyaleAPI.Models.Players;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace ClashRoyaleAPI
{
    public static class Core
    {
        private const string BaseURL = "https://api.clashroyale.com/";
        public static string Token = string.Empty;
        public static string CurrentURL = string.Empty;

        public static void Init(string Token,VersionAPI version)
        {
            if (string.IsNullOrWhiteSpace(Token))
            {
                throw new ClashRoyaleAPIException("Token is not specified");
            }

            string tmpVersion = string.Empty;
            Core.Token = Token;
            switch (version)
            {
                case VersionAPI.v1:
                    tmpVersion = "v1/";
                    break;
                default:
                    tmpVersion = "v1/";
                    break;
            }
            CurrentURL = Path.Combine(BaseURL, tmpVersion);
        }
    }
}
