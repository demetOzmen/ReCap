﻿namespace Core.Dtos.Requests;

public class CreateProductRequest
{
    public int CategoryId { get; set; }
    public string ProductName { get; set; }
    public decimal UnitPrice { get; set; }
    public short UnitsInStock { get; set; }
    public string QuantityPerUnit { get; set; }
}