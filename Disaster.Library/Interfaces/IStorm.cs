﻿namespace Disaster.Library.Interfaces
{
    public interface IStorm : IDisaster
    {
        string WindSpeed { get; set; }
        float AmountOfPreciptitation { get; set; }
    }
}
