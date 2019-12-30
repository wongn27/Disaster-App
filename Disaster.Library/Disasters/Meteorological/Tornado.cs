using Disaster.Library.Interfaces;
using System;

namespace Disaster.Library.Disasters.Meteorological
{
    public class Tornado : IStorm, IPhoto, ICost
    {
        public string WindSpeed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Location { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string PhotoLocation { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public long NumberOfCasualties { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime Date { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public float AmountOfPreciptitation { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public decimal Cost { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Caption { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
