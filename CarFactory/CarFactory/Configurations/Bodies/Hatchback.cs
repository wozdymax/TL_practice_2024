using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory.Configurations.Bodies;
public class Hatchback : IBody
{
    public string Name => "Хетчбек";
    public int SpeedBoost => 5;
    public int FuelConsumption => 2;
    public int Cost => 1900;
}
