using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;


public class Order
{
    [Key]
    public int IdOrder { get; set; }
    public int IdMaster { get; set; }
    public DateTime OrderDate { get; set; }
    public Master? Master { get; set; }
    public string? Comment { get; set; }
    public ICollection<OrderSparePart>? OrderSpareParts { get; set; }
    public ICollection<OrderMalfunction>? OrderMalfunctions { get; set; }
    public ICollection<OrderWork>? OrderWorks { get; set; }
}