using System;

namespace Disaster.Library.Interfaces
{
    public interface IDisaster
    {
        string Name { get; set; }
        string Location { get; set; }
        long NumberOfCasualties { get; set; }
        DateTime Date { get; set; }
    }
}
