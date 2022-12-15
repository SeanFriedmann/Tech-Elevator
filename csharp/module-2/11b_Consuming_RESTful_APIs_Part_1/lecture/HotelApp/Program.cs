namespace HotelApp
{
    class Program
    {
        private const string ApiUrl = "http://localhost:3000/"; //our local http server, url of the api we want data from
        static void Main()
        {
            HotelApp app = new HotelApp(ApiUrl); //run hotel app
            app.Run();
        }
    }
}
