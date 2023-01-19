public class ProductDto
{
  public ProductDto()
  {
    
  }
  public int Id { get; set; }
  public string Name { get; set; }
  public decimal Price { get; set; }
  public string FirstName { get; set; }
  public string Address { get; set; }

  public ProductDto(int id, string name, decimal price)
  {
    Id = id;
    Name = name;
    Price = price;

  }
}