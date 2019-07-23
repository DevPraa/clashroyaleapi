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
    public sealed class Core
    {

        private static readonly Lazy<Core> _instance = new Lazy<Core>(() => new Core());

        Core() { }

        private readonly string BaseURL = "https://api.clashroyale.com/";

        public static Core Instance { get { return _instance.Value; } }


        public string Token { get; private set; }
        public string CurrentURL { get; private set; }

        public void Init(string Token, VersionAPI version)
        {
            if (string.IsNullOrWhiteSpace(Token))
            {
                throw new ClashRoyaleAPIException("Token is not specified");
            }

            string tmpVersion = string.Empty;
            this.Token = Token;
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
