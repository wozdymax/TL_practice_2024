using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fighters.Models.Races;
public class Dwarf : IRace
{
    public string Name => "Dwarf";
    public int Damage => 10;

    public int Health => 100;

    public int Armor => 0;
}
