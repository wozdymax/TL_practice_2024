using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarFactory.Configurations.Bodies;
using CarFactory.Configurations.Brands;
using CarFactory.Configurations.Colors;
using CarFactory.Configurations.Engines;
using CarFactory.Configurations.Transmissions;

namespace CarFactory.Cars;
public interface ICar
{
    public IBrand Brand { get; }
    public IBody Body { get; }
    public IColor Color { get; }
    public IEngine Engine { get; }
    public ITransmission Transmission { get; }

    public int AverageSpeed { get; }
    public int FuelConsumtion { get; }
    public int TotalCost { get; }
}
