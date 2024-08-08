using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fighters.Models.FightersClasses;
public class Knight : IFightersClass
{
    public string Name => "Knight";
    public int Health => 40;
    public int Damage => 10;
}
