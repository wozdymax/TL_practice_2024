using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory.Configurations.Bodies;
public class Pickup : IBody
{
    public string Name => "Пикап";
    public int SpeedBoost => 5;
    public int FuelConsumption => 3;
    public int Cost => 2100;
}
