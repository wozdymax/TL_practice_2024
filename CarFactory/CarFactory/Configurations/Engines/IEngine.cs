using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory.Configurations.Engines;
public interface IEngine
{
    public string Name { get; }
    public double Capacity { get; }
    public int Speed { get; }
    public int FuelConsumption { get; }
    public int Cost { get; }

}
