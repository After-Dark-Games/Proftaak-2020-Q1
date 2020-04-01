﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Models
{
    public class Depot
    {
        public int Id { get; set; }
        public string Location { get; set; }
        public ICollection<User> Users { get; set; }
        public ICollection<Track> DepotTracks { get; set; }
    }
}
