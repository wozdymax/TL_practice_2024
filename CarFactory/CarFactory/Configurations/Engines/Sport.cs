using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory.Configurations.Engines;
public class Sport : IEngine
{
    public string Name => "Спорт";
    public double Capacity => 1.8;
    public int Speed => 100;
    public int FuelConsumption => 10;
    public int Cost => 2900;
}