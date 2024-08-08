using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fighters.Models.FightersClasses;
public class Legionnaire : IFightersClass
{
    public string Name => "Legionnaire";
    public int Health => 33;
    public int Damage => 15;
}
