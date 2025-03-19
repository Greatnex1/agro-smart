using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography.X509Certificates;

namespace AgroSmart.Models;

public class Product
{
public int Id { get; set; }

public string Name { get; set; }

public decimal Price { get; set; }

 public String Image { get; set; }
 public string ProductColor { get; set; }
 public bool IsAvailable { get; set; }
      
public string Description { get; set; }

public int CategoryId { get; set; }

[ForeignKey("CategoryId")]
public Category Categories { get; set; }

private int BrandId { get; set; }   

[ForeignKey("BrandId")]
public Brand Brands { get; set;} 

public DateTime DateCreated { get; set; } = DateTime.UtcNow;
public DateTime DateUpdated { get; set;}  

 }
