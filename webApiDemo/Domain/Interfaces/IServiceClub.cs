using webApiDemo.Domain.Entities;
using webApiDemo.Domain.Entities.DTOs;

namespace webApiDemo.Domain.Interfaces
{
    public interface IServiceClub
    {
        Club CalculatePercentage(ClubDTO clubDTO);
    }
}
