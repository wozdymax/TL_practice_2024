using System.Security.Cryptography;
using CarFactory.Cars;
using CarFactory.CarService;
using CarFactory.FactoryManagment;

namespace CarFactory;

public class Program
{
    static void Main()
    {
        IFactoryManager gameManager = new FactoryManager( new CarAssembly() );
        gameManager.Run();
    }
}