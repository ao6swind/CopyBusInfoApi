using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace Models
{
    public class Stop
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "站牌代碼")]
        [JsonProperty("Id")]
        public int Id { get; set; }
        [Display(Name = "所屬路線代碼")]
        [JsonProperty("routeId")]
        public string RouteId { get; set; }
        [Display(Name = "路線名稱")]
        [JsonProperty("nameZh")]
        public string Name { get; set; }
        [Display(Name = "位於路線上的順序")]
        [JsonProperty("seqNo")]
        public int Number { get; set; }
        [Display(Name = "去返程")]
        [JsonProperty("goBack")]
        public int GoBack { get; set; }
        [Display(Name = "經度")]
        [JsonProperty("longitude")]
        public float Longitude { get; set; }
        [Display(Name = "緯度")]
        [JsonProperty("latitude")]
        public float Latitude { get; set; }
        [Display(Name = "地址")]
        [JsonProperty("address")]
        public string Address { get; set; }
    }
}
