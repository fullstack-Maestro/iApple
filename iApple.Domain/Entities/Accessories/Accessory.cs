using iApple.Domain.Commons;

namespace iApple.Domain.Entities.Accessory;

public class Accessory : Auditable
{
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { set; get; }
    public long CategoryId { set; get; }
}