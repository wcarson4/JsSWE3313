using SWE3313_JsRestaurant.Data.Enums;

namespace SWE3313_JsRestaurant.Data.Entities;

public class Role
{
    public string RoleName { get; set; }
    private ICollection<RolePermission> RolePermissions { get; set; }
    
    
    protected internal bool IsAuthorized(object operand, Operation operation)
    {
        var result = RolePermissions.Where(permission =>
            permission.GetOperand() == operand && permission.GetOperation() == operation);
        
        return result.Any();
    }
}