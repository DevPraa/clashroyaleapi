using ClashRoyaleAPI.Exceptions;
using ClashRoyaleAPI.Models.Cards;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashRoyaleAPI.BL
{
    public class Cards : Base
    {
        string _Url;
        public Cards()
        {
            _Url = Path.Combine(Core.CurrentURL, "cards");
        }


        public AllCards GetAllCards()
        {
            try
            {
                return ApiReqest<AllCards>(_Url);
            }
            catch (ClashRoyaleAPIException ex)
            {
                throw ex;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
