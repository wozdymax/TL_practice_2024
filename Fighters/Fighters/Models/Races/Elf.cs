using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fighters.Models.Races;
public class Elf : IRace
{
    public string Name => "Elf";
    public int Damage => 8;

    public int Health => 100;

    public int Armor => 0;
}
