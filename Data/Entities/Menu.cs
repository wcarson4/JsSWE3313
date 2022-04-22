namespace SWE3313_JsRestaurant.Data.Entities;

public class Menu
{
    private string MenuName { get; set; }
    private List<MenuItem> MenuItems { get; set; }
    public Menu(string menuName, List<MenuItem>? menuItems)
    {
        MenuName = menuName;
        MenuItems = menuItems ?? new List<MenuItem>();
    }

    public void AddMenuItem(MenuItem item)
    {
        MenuItems.Add(item);
    }
    
    public void RemoveMenuItem(MenuItem item)
    {
        MenuItems.Remove(item);
    }
}