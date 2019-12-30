using Disaster.Library.Interfaces;
using System;
using System.Xml.Serialization;

namespace Disaster.Library.Disasters.Hydrological
{
    [XmlRoot("DisasterDataSet")]
    public class Tsunami : IDisaster, IPhoto, ICost
    {
        [XmlElement(nameof(Name))]
        public string Name { get; set; }

        [XmlElement(nameof(Location))]
        public string Location { get; set; }

        [XmlElement(nameof(NumberOfCasualties))]
        public long NumberOfCasualties { get; set; }

        [XmlElement(nameof(Date))]
        public DateTime Date { get; set; }

        public string PhotoLocation { get; set; }

        public string Caption { get; set; }

        [XmlElement(nameof(Cost))]
        public decimal Cost { get; set; }
    }
}
