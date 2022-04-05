using System.Collections.Generic;
using System.Collections;
namespace eModal
{
    public class User
    {
        public int id { get; set; }
        public string? user_firstname { get; set; }
        public string? user_lastname { get; set; }
        public string? user_contact { get; set; }
        public string? user_email { get; set; }
        public string? user_username { get; set; }
        public string? user_password { get; set; }
        public string? user_document { get; set; }
        public string? user_profilephoto { get; set; }
        public string? user_company_name { get; set; }
        public string? user_watchlist { get; set; }
        public bool user_status { get; set; }
        public string? user_token { get; set; }
        public bool user_authentication { get; set; }
        public DateTime? user_registration_date { get; set; }
    }
}
