using GFTD.Models.Response;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace GFDT.Models.Response
{
   public class GetusergiftResponse:BaseResponseModel
    {
        [JsonProperty(PropertyName = "Datum")]
        public List<GiftItems> data { get; set; }
    }
    public class User
    {
        public int id { get; set; }
        public string name { get; set; }
        public string image { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string mobile { get; set; }
        public object email_verified_at { get; set; }
        public string api_token { get; set; }
        public string device_token { get; set; }
        public int status { get; set; }
        public object updated_by { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }
    }

    public class GiftItems
    {
        public int gift_send_type { get; set; }
        public string user_name { get; set; }
        public string other_user_name { get; set; }
        public string date { get; set; }
        public string product_image { get; set; }
        public string product_name { get; set; }
    }
}
