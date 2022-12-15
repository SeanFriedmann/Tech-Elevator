using HotelReservationsClient.Models;
using RestSharp;
using RestSharp.Authenticators;

namespace HotelReservationsClient.Services
{
    public class AuthenticationApiService : ApiService
    {
        private static ApiUser user = new ApiUser();
        public bool LoggedIn { get { return !string.IsNullOrWhiteSpace(user.Token); } } //checks whether or not there is a token
        public AuthenticationApiService(string apiUrl) : base(apiUrl) { } //class constructor

        public bool Login(string submittedName, string submittedPass) //take user and pass from client
        {
            LoginUser loginUser = new LoginUser { Username = submittedName, Password = submittedPass }; //login user object
            RestRequest request = new RestRequest("login"); //rest request for server
            request.AddJsonBody(loginUser);
            IRestResponse<ApiUser> response = client.Post<ApiUser>(request);

            CheckForError(response, "Login");
            user.Token = response.Data.Token; //

            // TODO: Set the token on the client, restsharp will attach token to all requests after you set it up
            client.Authenticator = new JwtAuthenticator(user.Token); //give your client authenticator your jwt user token
            //send the logged in users token on all subsequent requests

            return true; //return true if user was able to login
        }

        public void Logout()
        {
            user = new ApiUser();

            // TODO: Remove the token from the client
            client.Authenticator = null;

        }
    }
}
