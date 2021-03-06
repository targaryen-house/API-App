﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;
using System.Transactions;

namespace API_SwitchBack.Models
{
    public class GetTrails
    {
        public int ID { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("summary")]
        public string Summary { get; set; }
        [JsonProperty("difficulty")]
        public string Difficulty { get; set; }
        [JsonProperty("stars")]
        public double Stars { get; set; }
        [JsonProperty("starVotes")]
        public int StarVotes { get; set; }
        [JsonProperty("location")]
        public string Location { get; set; }
        [JsonProperty("url")]
        public string Url { get; set; }
        [JsonProperty("imgSqSmall")]
        public string ImgSqSmall { get; set; }
        [JsonProperty("imgSmall")]
        public string ImgSmall { get; set; }
        [JsonProperty("imgSmallMed")]
        public string ImgSmallMed { get; set; }
        [JsonProperty("imgMedium")]
        public string ImgMedium { get; set; }
        [JsonProperty("length")]
        public double Length { get; set; }
        [JsonProperty("ascent")]
        public int Ascent { get; set; }
        [JsonProperty("descent")]
        public int Descent { get; set; }
        [JsonProperty("high")]
        public int High { get; set; }
        [JsonProperty("low")]
        public int Low { get; set; }
        [JsonProperty("longitude")]
        public double Longitude { get; set; }
        [JsonProperty("latitude")]
        public double Latitude { get; set; }
        [JsonProperty("conditionStatus")]
        public string ConditionStatus { get; set; }
        [JsonProperty("conditionDetails")]
        public string ConditionDetails { get; set; }
        [JsonProperty("conditionDate")]
        public string ConditionDate { get; set; }

    }
}
