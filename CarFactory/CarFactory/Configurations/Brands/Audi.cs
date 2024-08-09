using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory.Configurations.Brands;
public class Audi : IBrand
{
    public string Name => "Ауди";
    public int ComponentsCost => 3300;
}
