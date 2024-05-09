namespace Models.Domain;

public class ProductModel
{
    public string Description { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }
    public DateTime CreationDate { get; set; }
}