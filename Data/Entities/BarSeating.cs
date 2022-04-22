using SWE3313_JsRestaurant.Data.Enums;
using SWE3313_JsRestaurant.Data.Interfaces;

namespace SWE3313_JsRestaurant.Data.Entities;

public class BarSeating : ISeatable, ICleanable
{
    private readonly int MaxOccupancy = 1; 
    private (int,char) Location { get; set; }
    private int CurrentlySeatedGuests { get; set; }
    private SeatingStatus Status { get; set; }
    
    public void SeatGuests(int numberOfGuests)
    {
        if(numberOfGuests > MaxOccupancy)
            throw new InsufficientSeatingException();

        CurrentlySeatedGuests += numberOfGuests;
    }

    public void PartyOver()
    {
        CurrentlySeatedGuests -= 1;
    }

    public void SetCleanTable()
    {
        throw new NotImplementedException();
    }

    public void SetDirtyTable()
    {
        throw new NotImplementedException();
    }
}