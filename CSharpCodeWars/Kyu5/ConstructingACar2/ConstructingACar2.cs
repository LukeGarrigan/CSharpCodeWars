using System;

namespace CSharpCodeWars.Kyu5.ConstructingACar2;

public interface ICar
{
    bool EngineIsRunning { get; }

    void BrakeBy(int speed); // car #2

    void Accelerate(int speed); // car #2

    void EngineStart();

    void EngineStop();

    void FreeWheel(); // car #2

    void Refuel(double liters);

    void RunningIdle();
}

public interface IDrivingInformationDisplay // car #2
{
    int ActualSpeed { get; }
}

public interface IDrivingProcessor // car #2
{
    int ActualSpeed { get; }

    void IncreaseSpeedTo(int speed);

    void ReduceSpeed(int speed);
}

public interface IEngine
{
    bool IsRunning { get; }

    void Consume(double liters);

    void Start();

    void Stop();
}

public interface IFuelTank
{
    double FillLevel { get; }

    bool IsOnReserve { get; }

    bool IsComplete { get; }

    void Consume(double liters);

    void Refuel(double liters);
}

public interface IFuelTankDisplay
{
    double FillLevel { get; }

    bool IsOnReserve { get; }

    bool IsComplete { get; }
}

public class Car : ICar
{
    public IFuelTankDisplay fuelTankDisplay;
    private IEngine engine;
    private IFuelTank fuelTank;
    private DrivingProcessor drivingProcessor;
    public IDrivingInformationDisplay drivingInformationDisplay;


    public Car() : this(20, 10)
    {
    }

    public Car(double fuelLevel) : this(fuelLevel, 10)
    {
    }


    public Car(double fuelLevel, int maxAcceleration)
    {
        if (maxAcceleration > 20)
        {
            maxAcceleration = 20;
        }
        else if (maxAcceleration < 5)
        {
            maxAcceleration = 10;
        }

        drivingProcessor = new DrivingProcessor(maxAcceleration);
        drivingInformationDisplay = new DrivingInformationDisplay(drivingProcessor);
        fuelTank = new FuelTank(fuelLevel);
        fuelTankDisplay = new FuelTankDisplay(fuelTank);
        engine = new Engine(fuelTank);
    }

    public bool EngineIsRunning => engine.IsRunning;

    public void BrakeBy(int speed)
    {
        drivingProcessor.ReduceSpeed(speed);
        ConsumePetrol();
    }

    public void RunningIdle()
    {
        if (EngineIsRunning)
        {
            engine.Consume(0.0003);
        }
    }

    public void EngineStart()
    {
        engine.Start();
    }

    public void EngineStop()
    {
        engine.Stop();
    }

    public void Accelerate(int speed)
    {
        if (EngineIsRunning)
        {
            if (speed < drivingProcessor.ActualSpeed)
            {
                FreeWheel();
            }
            else
            {
                drivingProcessor.IncreaseSpeedTo(speed);
                ConsumePetrol();
            }
        }
    }

    public void FreeWheel()
    {
        if (EngineIsRunning)
        {
            if (drivingProcessor.ActualSpeed == 0)
            {
                RunningIdle();
            }
            else
            {
                drivingProcessor.ReduceSpeed(1);
                ConsumePetrol();
            }
        }
    }

    public void Refuel(double amount)
    {
        fuelTank.Refuel(amount);
    }

    private void ConsumePetrol()
    {
        if (EngineIsRunning)
        {
            switch (drivingProcessor.ActualSpeed)
            {
                case >= 1 and <= 60:
                    engine.Consume(0.0020);
                    break;
                case >= 61 and <= 100:
                    engine.Consume(0.0014);
                    break;
                case >= 101 and <= 140:
                    engine.Consume(0.0020);
                    break;
                case >= 141 and <= 200:
                    engine.Consume(0.0025);
                    break;
                case >= 201 and <= 250:
                    engine.Consume(0.0030);
                    break;
            }
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

    public class DrivingInformationDisplay : IDrivingInformationDisplay
    {
        private readonly DrivingProcessor _drivingProcessor;

        public DrivingInformationDisplay(DrivingProcessor drivingProcessor)
        {
            _drivingProcessor = drivingProcessor;
        }

        public int ActualSpeed => _drivingProcessor.ActualSpeed;
    }

    public class DrivingProcessor : IDrivingProcessor
    {
        private readonly int _maxAcceleration;
        public int ActualSpeed { get; set; }

        public DrivingProcessor(int maxAcceleration)
        {
            _maxAcceleration = maxAcceleration;
        }

        public void IncreaseSpeedTo(int speed)
        {
            if (ActualSpeed <= speed)
            {
                ActualSpeed += _maxAcceleration;
                if (ActualSpeed > speed) ActualSpeed = speed;
                if (ActualSpeed > 250) ActualSpeed = 250;
            }
        }

        public void ReduceSpeed(int speed)
        {
            if (ActualSpeed > 0)
            {
                ActualSpeed -= (speed > 10 ? 10 : speed);
                if (ActualSpeed < 0) ActualSpeed = 0;
            }
        }
    }
}