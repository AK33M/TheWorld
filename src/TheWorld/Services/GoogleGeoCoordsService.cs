using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace TheWorld.Services
{
    public class GoogleGeoCoordsService : IGeoCoordsService
    {
        private IConfigurationRoot _config;
        private ILogger<BingGeoCoordsService> _logger;

        public GoogleGeoCoordsService(ILogger<BingGeoCoordsService> logger, IConfigurationRoot config)
        {
            _logger = logger;
            _config = config;
        }

        public async Task<GeoCoordsResult> GetCoordsAsync(string name)
        {
            var result = new GeoCoordsResult
            {
                Success = false,
                Message = "Failed to get coordinates"
            };

            var apiKey = _config["Keys:GoogleKey"];
            var encodedName = WebUtility.UrlEncode(name);
            var url = $"https://maps.googleapis.com/maps/api/geocode/json?address={encodedName}&key={apiKey}";

            var client = new HttpClient();

            var json = await client.GetStringAsync(url);


            var results = JObject.Parse(json);
            var location = results["results"][0]["geometry"]["location"];
            var status = results["status"];

            if (!location.HasValues)
            {
                result.Message = $"Could not find '{name}' as a location";
            }
            else
            {
                result.Latitude = (double)location["lat"];
                result.Longitude = (double)location["lng"];
                result.Success = true;
                result.Message = status.ToString();
            }

            return result;
        }
    }
}
