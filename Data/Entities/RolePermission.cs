using SWE3313_JsRestaurant.Data.Enums;

namespace SWE3313_JsRestaurant.Data.Entities;

public class RolePermission
{
    private object Operand { get; set; }
    private string RolePermissionName { get; set; }
    private Operation Operation { get; set; }

    public RolePermission(object operationalEntity, string rolePermissionName, Operation operation)
    {
        Operand = operationalEntity;
        RolePermissionName = rolePermissionName;
        Operation = operation;
    }

    protected internal object GetPermission()
    {
        return new {operand = Operand, operation = Operation};
    }
    
    protected internal object GetOperand()
    {
        return Operand;
    }
    
    protected internal Operation GetOperation()
    {
        return Operation;
    }
    
}