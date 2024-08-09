using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory.Configurations.Colors;
public interface IColor
{
    public string Name { get; }
    public int Cost { get; }
}
