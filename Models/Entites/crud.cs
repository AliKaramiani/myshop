
using System.ComponentModel.DataAnnotations;

public class Crud
{
    [Key]
    public int ID { get; set; }
    [Required]
    public string ProductName { get; set; }
    public int Price { get; set; }
    public int Number { get; set; }

}