using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace Models
{
    public class Route
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "路線代碼")]
        [JsonProperty("Id")]
        public int Id { get; set; }
        [Display(Name = "路線名稱")]
        [JsonProperty("nameZh")]
        public string Name { get; set; }
        [Display(Name = "業者名稱")]
        [JsonProperty("providerName")]
        public string ProviderName { get; set; }
    }
}
