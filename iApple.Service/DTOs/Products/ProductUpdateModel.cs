﻿namespace iApple.Service.DTOs.Products;

public class ProductUpdateModel
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string Color { get; set; }
    public decimal Price { get; set; }
    public string Storage { get; set; }
    public long CategoryId { get; set; }
}