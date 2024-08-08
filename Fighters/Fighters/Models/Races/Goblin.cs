using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fighters.Models.Races;
internal class Goblin : IRace
{
    public string Name => "Goblin";
    public int Damage => 15;

    public int Health => 100;

    public int Armor => 0;
}
