using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fighters.Models.Weapons;
public class Dagger : IWeapon
{
    public string Name => "Dagger";
    public int Damage => 9;
}
