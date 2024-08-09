using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory.Configurations.Bodies;
public class Coupe : IBody
{
    public string Name => "Купе";
    public int SpeedBoost => 10;
    public int FuelConsumption => 1;
    public int Cost => 1700;
}
