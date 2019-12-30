using Disaster.Library.Interfaces;
using System;

namespace Disaster.Library.Disasters.Meteorological
{
    public class Blizzard : IStorm, IPhoto, ICost
    {
        private DateTime _date;
        public float AmountOfPreciptitation { get; set; }
        public string WindSpeed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Location { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public long NumberOfCasualties { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime Date { get; set; }
        public decimal Cost { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Caption { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
