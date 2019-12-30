using Disaster.Library.Interfaces;
using System;
using System.Xml.Serialization;

namespace Disaster.Library.Disasters.Geological
{
    [XmlRoot("DisasterDataSet")]
    public class Avalanche : IDisaster, IPhoto, ICost
    {
        [XmlElement(nameof(Name))]
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        
        [XmlElement(nameof(Location))]
        public string Location { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string PhotoLocation { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        [XmlElement(nameof(NumberOfCasualties))]
        public long NumberOfCasualties { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        [XmlElement(nameof(Date))]
        public DateTime Date { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string Caption { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        [XmlElement(nameof(Cost))]
        public decimal Cost { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    }
}
