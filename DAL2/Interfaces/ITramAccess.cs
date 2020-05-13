﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;
using DTO;

namespace DAL.Interfaces
{
    public interface ITramAccess : IGenAccess<TramDTO>
    {
        IEnumerable<TramDTO> GetAllTrams();
        List<int> GetAllTramIds();
        TramDTO ReadFromTramNumber(string tramNumber);
        int GetKeyFromTramNumber(string tramNumber);
        int GetSectorIdFromTram(int key);
    }
}
