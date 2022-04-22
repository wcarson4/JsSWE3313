namespace SWE3313_JsRestaurant.Data.Entities;

public class User
{
    public string UserName { get; set; }
    private string Password { get; set; }
    private double HourlyWage { get; set; }
    private Role UserRole { get; set; }

    public Role GetUserRole()
    {
        return UserRole;
    }

    public object GetCrentials()
    {
        return new {userName = UserName, password = Password};
    }
}