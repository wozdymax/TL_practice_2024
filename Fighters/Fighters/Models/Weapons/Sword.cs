using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fighters.Models.Weapons;
public class Sword : IWeapon
{
    public string Name => "Sword";
    public int Damage => 11;
}
