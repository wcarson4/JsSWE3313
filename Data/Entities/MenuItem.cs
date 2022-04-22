namespace SWE3313_JsRestaurant.Data.Entities;

public class MenuItem
{
    private int MenuItemId { get; set; }
    private string ItemName { get; set; }
    private string ItemDescription { get; set; }
    protected internal double ItemPrice { get; set; }

    public MenuItem(string name, string? description, double price)
    {
        MenuItemId = 0;
        ItemName = name;
        ItemDescription = description ?? string.Empty;
        ItemPrice = price;
    }
}