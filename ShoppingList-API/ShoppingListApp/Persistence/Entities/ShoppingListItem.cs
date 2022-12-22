using System.ComponentModel.DataAnnotations;

namespace ShoppingListApp.Persistence.Entities;

public class ShoppingListItem
{
    [Required]
    public Guid Id { get; init; }
    [Required]
    public string Name { get; set; }
    
    public int Quantity { get; set; }
    
    public QuantityTypeEnum QuantityType { get; set; }
    
    public bool Done { get; set; }

    public ShoppingListItem(Guid id, string name, int quantity, QuantityTypeEnum quantityType, bool done)
    {
        Id = id;
        Name = name;
        Quantity = quantity;
        QuantityType = quantityType;
        Done = done;
    }

    private ShoppingListItem() { }
    
    // TODO Add possibility to add images
}