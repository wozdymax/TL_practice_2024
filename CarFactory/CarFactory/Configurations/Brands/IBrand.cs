using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory.Configurations.Brands;
public interface IBrand
{
    public string Name { get; }
    public int ComponentsCost { get; }
}
