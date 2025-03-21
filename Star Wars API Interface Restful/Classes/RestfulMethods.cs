using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace Star_Wars_API_Interface_Restful.Classes
{
    internal class RestfulMethods
    {
        private const string baseURL = "https://swapi.dev/api/";
        private const string filmsRequestURL = "films/";
        private const string planetsRequestURL = "planets/";
        private const string peoplesRequestURL = "people/";


        public static List<Film> GetDeserializedFilms()
        {
            List<Film> _films; 
            var client = new RestClient(baseURL);
            RestResponse response = client.Execute(new RestRequest(filmsRequestURL));

            Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(response.Content);
            _films = myDeserializedClass.results;
            return _films;
        }
        public static Planet GetPlanet(string PlanetId)
        {
            Planet _planet;
            var client = new RestClient(baseURL);
            RestResponse response = client.Execute(new RestRequest(planetsRequestURL + "/" + PlanetId));

            Planet myDeserializedClass = JsonConvert.DeserializeObject<Planet>(response.Content);
            _planet = myDeserializedClass;
            return _planet;
        }

        public static Person GetPerson(string personId)
        {
            Person _person; 
            var client = new RestClient(baseURL);
            RestResponse response = client.Execute(new RestRequest(peoplesRequestURL + "/" + personId));

            Person myDeserializedClass = JsonConvert.DeserializeObject<Person>(response.Content);
            _person = myDeserializedClass;
            return _person;
        }

    }
}
