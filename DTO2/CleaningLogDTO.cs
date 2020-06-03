﻿using System;
using System.Collections.Generic;
using System.Text;
using Services;

namespace DTO
{
    public class CleaningLogDTO
    {
        public int Id { get; set; }
        public CleaningServiceDTO CleaningService { get; set; }
        public TramDTO Tram { get; set; }
        public UserDTO User { get; set; }
        public DateTime RepairDate { get; set; }
        public ServiceType ServiceType { get; set; }
        public bool Occured { get; set; }
        public string RepairMessage { get; set; }

        public CleaningLogDTO(int id, CleaningServiceDTO cleanService, TramDTO tram, UserDTO user, DateTime repairDate, ServiceType serviceType, bool occured, string repairMessage)
        {
            CleaningService = cleanService;
            Tram = tram;
            User = user;
            RepairDate = repairDate;
            ServiceType = serviceType;
            Occured = occured;
            RepairMessage = repairMessage;
        }
    }
}
