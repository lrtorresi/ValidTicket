using Domain.Model.Entities;
using Microsoft.Extensions.Configuration;
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
    public class StoreService : IStoreService
    {
        private readonly IOptions<AppSettings> _settings;
        private readonly IConfiguration _configuration;

        public StoreService(IOptions<AppSettings> settings, IConfiguration configuration)
        {
            _settings = settings;
            _configuration = configuration;
        }

        public async Task<string> GetStoreName()
        {
            _settings.Value.Uri = "http://localhost:6423/m7api.svc/v2/globalprefs/Cliente";

            var client = new RestClient(_settings.Value.Uri);
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);

            Root name = JsonConvert.DeserializeObject<Root>(response.Content);
            
            return name.response.globalprefs[0].conteudo;
        }
    }
}
