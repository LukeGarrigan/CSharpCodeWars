using System;

namespace CSharpCodeWars.Kyu5.ConstructingACar1;

public interface ICar
{
    
}

public interface IFuelTankDisplay
{
    public bool IsComplete { get; }
    public bool IsOnReserve { get; }
    public double FillLevel { get; }
}

public interface IEngine
{
    public bool IsRunning { get; }
    public void Stop();
    public void Start();
    public void Consume(double amount);
}

public interface IFuelTank
{
    public void Refuel(double amount);
    public void Consume(double amount);
    public bool IsOnReserve { get; }
    public bool IsComplete { get; }
    public double FillLevel { get; }
}

public class Car : ICar
{
    public IFuelTankDisplay fuelTankDisplay;
    private IEngine engine;
    private IFuelTank fuelTank;

    public Car()
    {
        fuelTank = new FuelTank();
        engine = new Engine(fuelTank);
        fuelTankDisplay = new FuelTankDisplay(fuelTank);
    }

    public Car(double fuelLevel)
    {
        fuelTank = new FuelTank(fuelLevel);
        engine = new Engine(fuelTank);
        fuelTankDisplay = new FuelTankDisplay(fuelTank);
    }

    public bool EngineIsRunning => engine.IsRunning;

    public void RunningIdle()
    {
        engine.Consume(0.0003);
    }

    public void EngineStart()
    {
        engine.Start();
    }

    public void EngineStop()
    {
        engine.Stop();
    }

    public void Refuel(double amount)
    {
        fuelTank.Refuel(amount);
    }
}

public class Engine : IEngine
{
    private readonly IFuelTank _fuelTank;
    public bool IsRunning { get; set; }

    public Engine(IFuelTank fuelTank)
    {
        _fuelTank = fuelTank;
    }

    public void Stop()
    {
        IsRunning = false;
    }

    public void Start()
    {
        if (_fuelTank.FillLevel > 0)
        {
            IsRunning = true;
        }
    }

    public void Consume(double amount)
    {
        if (!IsRunning) return;
            _fuelTank.Consume(amount);
        if (_fuelTank.FillLevel == 0)
        {
            Stop();
        }
    }
}

public class FuelTank : IFuelTank
{
    public double FillLevel { get; set; }

    public FuelTank(double fuelLevel)
    {
        Refuel(fuelLevel);
    }
    public bool IsOnReserve => FillLevel < 20;
    public bool IsComplete => FillLevel == 60;

    public FuelTank()
    {
        FillLevel = 20;
    }

    public void Refuel(double amount)
    {
        if (amount > 0)
        {
            FillLevel += amount;
            if (FillLevel > 60) FillLevel = 60;    
        }
    }

    public void Consume(double amount)
    {
        FillLevel -= amount;
        if (FillLevel < 0) FillLevel = 0;
    }
}

public class FuelTankDisplay : IFuelTankDisplay
{
    private readonly IFuelTank _fuelTank;

    public FuelTankDisplay(IFuelTank fuelTank)
    {
        _fuelTank = fuelTank;
    }

    public bool IsComplete => _fuelTank.IsComplete;
    public bool IsOnReserve => _fuelTank.IsOnReserve;

    public double FillLevel => Math.Round(_fuelTank.FillLevel, 2);
}