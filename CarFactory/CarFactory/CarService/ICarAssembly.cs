using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarFactory.Cars;

namespace CarFactory.CarService;
public interface ICarAssembly
{
    ICar AssemblingCar();
}
