﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class TramDTO
    {
        public int Id { get; set; }
        public string SerialNumber { get; set; }
        public TramType Type { get; set; }
        public ICollection<TramStatus> Statuses { get; set; }
        private ICollection<TrackDTO> PreferredTracksList { get; set; }
    }
    public enum TramStatus
    {
        Defect,
        Cleaning,
        Shift,
        Depot,
    }
    public enum TramType
    {
        Combino,
        DoubleCombino,
        ElevenG,
        TwelveG,
        TrainingTram,

    }
}
