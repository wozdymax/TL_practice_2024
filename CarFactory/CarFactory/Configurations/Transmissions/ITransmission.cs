using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory.Configurations.Transmissions;
public interface ITransmission
{
    public string Name { get; }
    public int Gears { get; }
    public int SpeedBoost { get; }
    public int Cost { get; }
}
