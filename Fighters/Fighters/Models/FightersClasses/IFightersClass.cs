using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fighters.Models.FightersClasses;
public interface IFightersClass
{
    public string Name { get; }
    public int Health { get; }
    public int Damage { get; }
}