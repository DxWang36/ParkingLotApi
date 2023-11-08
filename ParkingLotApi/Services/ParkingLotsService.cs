﻿using Microsoft.AspNetCore.Mvc;
using ParkingLotApi.Dtos;
using ParkingLotApi.Models;

namespace ParkingLotApi.Services
{
    public class ParkingLotsService
    {
        public async Task<ParkingLotDto> CreateAsync( ParkingLotDto parkingLotDto)
        {
            if (parkingLotDto.Capacity < 10) throw new ArgumentException();
            return null;
        }
    }
}
