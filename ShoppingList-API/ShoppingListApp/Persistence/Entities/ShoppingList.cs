using System.ComponentModel.DataAnnotations;

namespace ShoppingListApp.Persistence.Entities;

public class ShoppingList
{
    [Required]
    public Guid Id { get; init; }
    
    [Required]
    public virtual AppUser Owner { get; init; }
    
    public DateTime Deadline { get; set; }
    
    public virtual IList<ShoppingListItem> ListItems { get; }

    public ShoppingList(Guid id, DateTime deadline, AppUser owner, IList<ShoppingListItem>? listItems = null)
    {
        Id = id;
        Deadline = deadline;
        Owner = owner;
        ListItems = listItems ?? new List<ShoppingListItem>();
    }

    private ShoppingList() { }
}