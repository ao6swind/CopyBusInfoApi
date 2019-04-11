using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace Models
{
    public class RealTimeInfomation
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "路線代碼")]
        [JsonProperty("RouteId")]
        public int RouteId { get; set; }
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "站牌代碼")]
        [JsonProperty("StopId")]
        public int StopId { get; set; }
        [Display(Name = "預估到站剩餘時間")]
        [JsonProperty("EstimateTime")]
        public int EstimateTime { get; set; }
        [Display(Name = "去返程")]
        [JsonProperty("GoBack")]
        public int GoBack { get; set; }
    }
}
