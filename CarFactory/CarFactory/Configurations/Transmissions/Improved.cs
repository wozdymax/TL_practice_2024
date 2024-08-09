using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory.Configurations.Transmissions;
public class Improved : ITransmission
{
    public string Name => "Премиум";
    public int Gears => 6;
    public int SpeedBoost => 20;
    public int Cost => 1400;
}
