using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory.Configurations.Brands;
public class Skoda : IBrand
{
    public string Name => "Шкода";
    public int ComponentsCost => 2600;
}
