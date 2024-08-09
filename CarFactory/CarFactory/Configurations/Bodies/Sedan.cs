using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory.Configurations.Bodies;
public class Sedan : IBody
{
    public string Name => "Седан";
    public int SpeedBoost => 7;
    public int FuelConsumption => 1;
    public int Cost => 1300;
}
