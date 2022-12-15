using CatCards.Models;
using RestSharp;

namespace CatCards.Services
{
    public class CatFactService : ICatFactService
    {
        protected static RestClient client = null;
        
        public CatFactService()
        {
           if(client == null)
            {
                client = new RestClient("https://cat-data.netlify.app/api/facts");
            }
        }
        
        public CatFact GetFact()
        {
            RestRequest request = new RestRequest("random");
            IRestResponse<CatFact> response = client.Get<CatFact>(request);
            if (!response.IsSuccessful)
            {
                return null;
            }
            return response.Data;
        }
    }
}
