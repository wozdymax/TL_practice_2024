using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fighters.Models.FightersClasses;
public class Vigilante : IFightersClass
{
    public string Name => "Vigilante";
    public int Health => 35;
    public int Damage => 13;
}
