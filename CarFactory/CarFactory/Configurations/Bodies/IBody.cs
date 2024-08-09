using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory.Configurations.Bodies;
public interface IBody
{
    public string Name { get; }
    public int SpeedBoost { get; }
    public int FuelConsumption { get; }
    public int Cost { get; }
}
