using Fighters.Factory;
using Fighters.GameManagement;
using Fighters.Models.Fighters;
using Fighters.Models.Races;

namespace Fighters;

public class Program
{
    static void Main()
    {
        IGameManager gameManager = new GameManager( new FightersFactory() );
        gameManager.Play();
    }
}
