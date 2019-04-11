using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Route
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string ProviderName { get; set; }
        public int PathAttrivuteId { get; set; }
    }
}
