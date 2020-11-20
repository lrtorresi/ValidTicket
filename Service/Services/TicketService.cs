using Domain.Model.Entities;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using RestSharp;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class TicketService : ITicketService
    {
        private readonly IOptions<AppSettings> _settings;

        public TicketService(IOptions<AppSettings> settings)
        {
            _settings = settings;
        }

        public async Task<Root> getStatusTicket(Ticket entity)
        {
            var t = "{" + "\"pdv_qrcode\"" + ":" + "\"" + entity.QrCode + "\"" + "}";
            

            _settings.Value.Uri = "http://localhost:6423/m7api.svc/v2/contas/validaQrCode";
            var client = new RestClient(_settings.Value.Uri);
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddParameter("application/javascript", t, ParameterType.RequestBody);
            IRestResponse response = await client.ExecuteAsync(request);

            Root result = JsonConvert.DeserializeObject<Root>(response.Content);

            return result;
        }
    }
}
