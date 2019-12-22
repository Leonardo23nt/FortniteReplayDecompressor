﻿using System;
using System.Collections.Generic;
using System.Text;
using Unreal.Core.Models;

namespace FortniteReplayReader.Models
{
    public class Aircraft
    {
        public FVector FlightStartLocation { get; set; }
        public FRotator FlightRotation { get; set; }
    }
}