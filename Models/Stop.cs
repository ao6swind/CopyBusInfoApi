using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Stop
    {
        [Key]
        public int Id { get; set; }
        public string RouteId { get; set; }
        public string Name { get; set; }
        public int Number { get; set; }
        public int GoBack { get; set; }
        public float Longitude { get; set; }
        public float Latitude { get; set; }
        public string Address { get; set; }
    }
}
