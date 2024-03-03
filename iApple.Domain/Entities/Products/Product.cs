using iApple.Domain.Commons;

namespace iApple.Domain.Entities.Product;

public class Product : Auditable
{
    public string Name { get; set; }
    public string Color { get; set; }
    public decimal Price { get; set; }
    public long Quantity { get; set; }
    public string Storage { get; set; }
    public long CategoryId { get; set; }
    public string Description { get; set; }
}