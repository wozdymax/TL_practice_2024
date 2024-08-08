using System.Diagnostics;
using Fighters.Models.Armors;
using Fighters.Models.FightersClasses;
using Fighters.Models.Races;
using Fighters.Models.Weapons;

namespace Fighters.Models.Fighters;

public interface IFighter
{
    public string Name { get; }
    public IFightersClass FightersClass { get; }
    public IRace Race { get; }
    public IWeapon Weapon { get; }
    public IArmor Armor { get; }

    public int CurrentHealth { get; }
    public int ArmorPoints { get; }
    public int MaxHealth { get; }

    public int AverageDamage { get; }
    public bool IsAlive { get; }

    public int CalculateDamage();
    public void TakeDamage( int damage );
}
