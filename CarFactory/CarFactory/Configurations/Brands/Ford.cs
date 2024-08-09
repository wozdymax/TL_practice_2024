using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory.Configurations.Brands;
public class Ford : IBrand
{
    public string Name => "Форд";
    public int ComponentsCost => 2500;
}
