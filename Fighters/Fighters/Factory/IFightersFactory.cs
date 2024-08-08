using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fighters.Models.Fighters;

namespace Fighters.Factory;
public interface IFightersFactory
{
    IFighter CreateFighter();
    List<IFighter> GetFighters();
}
