﻿using Disaster.Library.Interfaces;
using System;

namespace Disaster.Library.Disasters.Meteorological
{
    public class Hurricane : IStorm
    {
        public string WindSpeed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Location { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public long NumberOfCasualties { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime Date { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}