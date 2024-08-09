using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using CarFactory.Configurations.Bodies;
using CarFactory.Configurations.Brands;
using CarFactory.Configurations.Colors;
using CarFactory.Configurations.Engines;
using CarFactory.Configurations.Transmissions;

namespace CarFactory.Cars;
public class Car : ICar
{
    public IBrand Brand { get; }
    public IBody Body { get; }
    public IColor Color { get; }
    public IEngine Engine { get; }
    public ITransmission Transmission { get; }

    public int AverageSpeed { get; }
    public int FuelConsumtion { get; }
    public int TotalCost { get; }

    public Car(
        IBrand brand,
        IBody body,
        IColor color,
        IEngine engine,
        ITransmission transmission )
    {
        Brand = brand;
        Body = body;
        Color = color;
        Engine = engine;
        Transmission = transmission;
        AverageSpeed = Engine.Speed + Body.SpeedBoost + Transmission.SpeedBoost;
        FuelConsumtion = Engine.FuelConsumption + Body.FuelConsumption;
        TotalCost = Brand.ComponentsCost + Body.Cost + Color.Cost + Engine.Cost + Transmission.Cost;
    }

    public override string ToString()
    {
        return "Создан автомобиль со следующими конфигурациями:\n" +
            $"Марка: {Brand.Name}\n" +
            $"Кузов: {Body.Name} \n" +
            $"Цвет кузова: {Color.Name}\n" +
            $"Двигатель: {Engine.Name} (Объем: {Engine.Capacity} л)\n" +
            $"Коробка передач: {Transmission.Name} (Количество скоростей: {Transmission.Gears})\n" +
            $"Средняя скорость: {AverageSpeed} км/ч\n" +
            $"Расход топлива: {FuelConsumtion} л на 100 км \n" +
            $"### Общая стоимость автомобиля: {TotalCost}$ ###";
    }
}
