using System.ComponentModel.DataAnnotations.Schema;

namespace coffeeShopMVC.Models;

public class Product
{
    [Column("Product_id")]
    public int Id { get; set; }// this  gets and sets the product id 
    public string ProductName { get; set; }
    [Column("Price")]
    public double price { get; set; }
    [Column("Product_code")]
    public string productCode { get; set; }
    public string image { get; set; }
    [Column("Category")]
    public int category { get; set; }
    public string imagedescription { get; set; }
}