using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory.Configurations.Engines;
public class Standart : IEngine
{
    public string Name => "Стандарт";
    public double Capacity => 1.4;
    public int Speed => 80;
    public int FuelConsumption => 6;
    public int Cost => 2300;
}
