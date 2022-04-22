using SWE3313_JsRestaurant.Data.Enums;
using SWE3313_JsRestaurant.Data.Interfaces;

namespace SWE3313_JsRestaurant.Data.Entities;

public class TableSeating : ISeatable, ICleanable
{
    private readonly int MaxOccupancy = 4;
    private ICollection<TableSeat> _seats { get; set; }
    private (int,char) Location { get; set; }
    private int CurrentlySeatedGuests { get; set; }
    private User? WaitStaff { get; set; }
    private SeatingStatus Status { get; set; }

    public TableSeating((int,char) location)
    {
        _seats = new List<TableSeat>();
        CurrentlySeatedGuests = 0;
        Location = location;
        Status = SeatingStatus.Clean;
    }

    public string GetTableLocation()
    {
        return string.Concat(Location.Item1, Location.Item2);
    }

    public SeatingStatus GetTableStatus()
    {
        return Status;
    }

    protected internal User GetCurrentlyAssignedWaitStaff()
    {
        return WaitStaff ?? null;
    }

    protected internal void AssignWaitStaff(User user)
    {
        WaitStaff = user;
    }

    public void FreeWaitStaff()
    {
        WaitStaff = null;
    }
    
    public void SeatGuests(int numberOfGuests)
    {
        if(numberOfGuests > MaxOccupancy)
            throw new InsufficientSeatingException();

        CurrentlySeatedGuests += numberOfGuests;
    }

    public void PartyOver()
    {
        foreach(var seat in _seats)
        {
            SingleGuestLeave(seat);
        }
        SetDirtyTable();
    }
    
    public void SingleGuestLeave(TableSeat seat)
    {
        //TODO: don't like this
        //need a way to see which seats are occupied and which are not
        //probably do that when the wait staff is entering the order for each seat - don't care before then 
        CurrentlySeatedGuests -= 1;
    }

    public void SetCleanTable()
    {
        Status = SeatingStatus.Clean;
    }

    public void SetDirtyTable()
    {
        Exception e = new Exception();
        Status = SeatingStatus.Dirty;
    }
}

public class InsufficientSeatingException : Exception
{
    
}