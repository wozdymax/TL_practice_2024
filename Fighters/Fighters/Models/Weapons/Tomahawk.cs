using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fighters.Models.Weapons;
public class Tomahawk : IWeapon
{
    public string Name => "Tomahawk";
    public int Damage => 13;
}
