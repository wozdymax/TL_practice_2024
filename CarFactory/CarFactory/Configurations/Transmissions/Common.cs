using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory.Configurations.Transmissions;
public class Common : ITransmission
{
    public string Name => "Стандарт";
    public int Gears => 5;
    public int SpeedBoost => 10;
    public int Cost => 1000;
}
