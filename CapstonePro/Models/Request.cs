using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace CapstonePro.Models
{
    public class Request
    {
        [Key]
        public int Id { get; set; }

        [StringLength(80)]
        public string Description { get; set; } = null!;

        [StringLength(80)]
        public string Justification { get; set; } = null!;

        [StringLength(80)]
        public string? RejectionReason { get; set; }

        [StringLength(20)]
        public string DeliveryMode { get; set; } = "Pickup";

        [StringLength(10)]
        public string Status { get; set; } = "NEW";


        [Column(TypeName = "Decimal(11,2)")]
        public decimal Total { get; set; } = 0;
        public int UserId { get; set; }

        

        //[JsonIgnore]
        public virtual User? User { get; set; } = null!;

        //[JsonIgnore]
        public virtual List<RequestLine>? RequestLines { get; set; }




    }
}
