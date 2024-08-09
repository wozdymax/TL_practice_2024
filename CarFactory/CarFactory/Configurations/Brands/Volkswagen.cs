using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory.Configurations.Brands;
public class Volkswagen : IBrand
{
    public string Name => "Фольксваген";
    public int ComponentsCost => 2800;
}
