namespace iApple.Service.DTOs.Accessories;

public class AccessoryCreationModel
{
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { set; get; }
    public long CategoryId { set; get; }
}
