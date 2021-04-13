using System;
using webApiDemo.Domain.Entities;
using webApiDemo.Domain.Entities.DTOs;
using webApiDemo.Domain.Interfaces;

namespace webApiDemo.Services
{
    public class ServiceClub: IServiceClub
    {
        public Club CalculatePercentage(ClubDTO clubDTO)
        {
            var percentage = (Convert.ToDouble(clubDTO.PointsEarned) / Convert.ToDouble(clubDTO.GamesPlayed * 3)) * 100;

            return new Club
            {
                Name = clubDTO.Name,
                Percentage = percentage
            };
        }
    }
}
