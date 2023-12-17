using System.ComponentModel;

namespace Flights.Dtos
{
    public record FlightSearchParameters(

        [DefaultValue("12/25/22 10:30:00 AM")]
        DateTime? FromDate,

        [DefaultValue("12/26/22 10:30:00 AM")]
        DateTime? ToDate,

        string? From,

        string? Destination,

        [DefaultValue(1)]
        int? NumberOfPassengers
        );
}
