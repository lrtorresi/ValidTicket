using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Model.Entities
{
    class ResponseApi
    {
    }

    public class Globalpref
    {
        public string globalpref_id { get; set; }
        public string conteudo { get; set; }
    }

    public class Meta
    {
        public string api_version { get; set; }
        public string request { get; set; }
        public string http_code { get; set; }
        public int status_code { get; set; }
        public string status_message { get; set; }
        public int total_count { get; set; }
        public int limit { get; set; }
        public int offset { get; set; }
    }

    public class Response
    {
        public string pdv_qrcode { get; set; }
        public string contaId { get; set; }
        public string createAt { get; set; }
        public string consumoAt { get; set; }
        public string itemId { get; set; }
        public string item { get; set; }

        public List<Globalpref> globalprefs { get; set; }
    }

    public class Root
    {
        public Meta meta { get; set; }
        public Response response { get; set; }
    }
}
