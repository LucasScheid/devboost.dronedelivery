﻿using devboost.dronedelivery.felipe.DTO;
using devboost.dronedelivery.felipe.EF.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace devboost.dronedelivery.felipe.Services.Interfaces
{
    public interface IDroneService
    {
        Task<List<Drone>> GetAll();
        Task<List<DroneStatusDTO>> GetDrones();
    }
}