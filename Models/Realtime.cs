using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class RealTimeInfomation
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RouteId { get; set; }
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StopId { get; set; }
        public int EstimateTime { get; set; }
        public int GoBack { get; set; }
    }
}
