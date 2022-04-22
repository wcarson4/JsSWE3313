using SWE3313_JsRestaurant.Data.Enums;

namespace SWE3313_JsRestaurant.Data.Interfaces;

public interface ISeatable
{
    public void SeatGuests(int numberOfGuests);
    public void PartyOver();
}