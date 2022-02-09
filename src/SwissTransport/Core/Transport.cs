namespace SwissTransport.Core
{
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using SwissTransport.Models;


    public class Transport : ITransport, IDisposable
    {
        private const string WebApiHost = "https://transport.opendata.ch/v1/";

        private readonly HttpClient httpClient = new HttpClient();



        public Stations GetStations(string query)
        {
            if (!string.IsNullOrEmpty(query))
            {
                var uri = new Uri($"{WebApiHost}locations?query={query}");
                return this.GetObject<Stations>(uri);
            }
            return null;

        }
        public StationBoardRoot GetStationBoard(string station, string id)
        {
            if (string.IsNullOrEmpty(station))
            {
                throw new ArgumentNullException(nameof(station));
            }

            if (!string.IsNullOrEmpty(id))
            {
                var uri = new Uri($"{WebApiHost}stationboard?station={station}&id={id}");
                return this.GetObject<StationBoardRoot>(uri);
            }

            var uri2 = new Uri($"{WebApiHost}stationboard?station={station}");
            return this.GetObject<StationBoardRoot>(uri2);
        }

        public Connections GetConnections(string fromStation, string toStation, DateTime fromDate, DateTime fromTime)
        {
            if (!string.IsNullOrEmpty(toStation))
            {
                var uri = new Uri($"{WebApiHost}connections?from={fromStation}&to={toStation}&date={fromDate}&time={fromTime}");
                return this.GetObject<Connections>(uri);
            }
            else
            {
                var test = new Uri($"{WebApiHost}connections?from={fromStation}");
                return this.GetObject<Connections>(test);
            }
        }

        public void Dispose()
        {
            this.httpClient?.Dispose();
        }
        private T GetObject<T>(Uri uri)
        {
            HttpResponseMessage response = this.httpClient
                .GetAsync(uri)
                .GetAwaiter()
                .GetResult();
            string content = response.Content
                .ReadAsStringAsync()
                .GetAwaiter()
                .GetResult();

            return JsonConvert.DeserializeObject<T>(content);
        }
    }
}