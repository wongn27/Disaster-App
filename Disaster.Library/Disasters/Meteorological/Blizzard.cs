using Disaster.Library.Interfaces;
using System;
using System.Xml.Serialization;

namespace Disaster.Library.Disasters.Meteorological
{
    [XmlRoot("DisasterDataSet")]
    public class Blizzard : IStorm, IPhoto, ICost
    {
        [XmlElement(nameof(AmountOfPreciptitation))]
        public float AmountOfPreciptitation { get; set; }

        [XmlElement(nameof(WindSpeed))]
        public string WindSpeed { get; set; }

        [XmlElement(nameof(Name))]
        public string Name { get; set; }

        [XmlElement(nameof(Location))]
        public string Location { get; set; }

        public string PhotoLocation { get; set; }

        [XmlElement(nameof(NumberOfCasualties))]
        public long NumberOfCasualties { get; set; }

        [XmlElement(nameof(Date))]
        public DateTime Date { get; set; }

        [XmlElement(nameof(Cost))]
        public decimal Cost { get; set; }

        public string Caption { get; set; }
    }
}
