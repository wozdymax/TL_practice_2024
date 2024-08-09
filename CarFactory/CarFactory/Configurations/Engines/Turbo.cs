using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory.Configurations.Engines;
public class Turbo : IEngine
{
    public string Name => "Турбо";
    public double Capacity => 2.2;
    public int Speed => 120;
    public int FuelConsumption => 12;
    public int Cost => 3500;
}
