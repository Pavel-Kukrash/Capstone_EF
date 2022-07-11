using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace CapstonePro.Models
{
    [Index("RequestId", Name = "IX_RequestLines_RequestId")]
    public class RequestLine
    {
        [Key]
        public int Id { get; set; }
        public int RequestId { get; set; }
        public int ProductId { get; set; }

        [Range(0, int.MaxValue)]
        public int Quantity { get; set; }

        //[JsonIgnore]
        public virtual Product? Product { get; set; } = null!;

        [JsonIgnore]
        public virtual Request? Request { get; set; } = null!;

    }
}

