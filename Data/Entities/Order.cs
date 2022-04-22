namespace SWE3313_JsRestaurant.Data.Entities;

public class Order
{
    private int OrderId { get; set; }
    private List<MenuItem> MenuItems { get; set; }

    public Order()
    {
        OrderId = 0;
        MenuItems = new List<MenuItem>();
    }

    public void AddMenuItem(MenuItem item)
    {
        MenuItems.Add(item);
    }
    
    public void RemoveMenuItem(MenuItem item)
    {
        MenuItems.Remove(item);
    }

    public double GetOrderTotal()
    {
        return MenuItems.Sum(item => item.ItemPrice);
    }
}