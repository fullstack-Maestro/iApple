namespace iApple.Service.DTOs.Accessories;

public class AccessoryViewModel
{
    public long Id { set; get; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { set; get; }
    public long CategoryId { set; get; }
}
