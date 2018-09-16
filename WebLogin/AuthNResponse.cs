namespace WebLogin.Controllers
{
    public class json
    {
        public string access_token { get; set; }
        public int expires_in { get; set; }
        public string token_type { get; set; }
    }

    public class Error
    {
        public string error { get; set; }
        public string error_description { get; set; }
        public string invalid_grant { get; set; }
    }
}