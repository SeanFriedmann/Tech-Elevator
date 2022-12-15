using CatCards.Models;
using RestSharp;
using System.Net.Http;

namespace CatCards.Services
{
    public class CatPicService : ICatPicService
    {
       // protected static RestClient client = new RestClient ("https://cat-data.netlify.app/api/pictures");
        protected static RestClient client = null;

        public CatPicService()
        {
            if (client == null)
            {
                client = new RestClient("https://cat-data.netlify.app/api/pictures");
            }
        }
        public CatPic GetPic()
        {
            // CatPic catPicUrl;
            RestRequest request = new RestRequest("random"); 
            IRestResponse<CatPic> response = client.Get<CatPic>(request);
            if (!response.IsSuccessful)
            {
                return null;
            }
            return response.Data;
            // throw new System.NotImplementedException();
        }
    }
}
