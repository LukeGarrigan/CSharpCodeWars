using NUnit.Framework;
using FluentAssertions;

namespace CSharpCodeWars.Kyu5.ConstructingACar2;

public class ConstructingACar2Tests
{
    private Car _sut;

    [SetUp]
    public void Setup()
    {
        _sut = new Car();
    }

    // part 1 tests
    [Test]
    public void TestMotorStartAndStop()
    {
        var car = new Car();

        Assert.IsFalse(car.EngineIsRunning, "Engine could not be running.");

        car.EngineStart();

        Assert.IsTrue(car.EngineIsRunning, "Engine should be running.");

        car.EngineStop();

        Assert.IsFalse(car.EngineIsRunning, "Engine could not be running.");
    }

    [Test]
    public void TestFuelConsumptionOnIdle()
    {
        var car = new Car(1, 10);

        car.EngineStart();

        Enumerable.Range(0, 3000).ToList().ForEach(s => car.RunningIdle());

        Assert.AreEqual(0.10, car.fuelTankDisplay.FillLevel, "Wrong fuel tank fill level!");
    }

    [Test]
    public void TestFuelTankDisplayIsComplete()
    {
        var car = new Car(60, 10);

        Assert.IsTrue(car.fuelTankDisplay.IsComplete, "Fuel tank must be complete!");
    }

    [Test]
    public void TestFuelTankDisplayIsOnReserve()
    {
        var car = new Car(4, 10);

        Assert.IsTrue(car.fuelTankDisplay.IsOnReserve, "Fuel tank must be on reserve!");
    }

    [Test]
    public void TestRefuel()
    {
        var car = new Car(5, 10);

        car.Refuel(40);

        Assert.AreEqual(45, car.fuelTankDisplay.FillLevel, "Wrong fuel tank fill level!");
    }

    // part 2 tests
    [Test]
    public void TestStartSpeed()
    {
        var car = new Car();

        car.EngineStart();

        Assert.AreEqual(0, car.drivingInformationDisplay.ActualSpeed, "Wrong actual speed!");
    }

    [Test]
    public void TestFreeWheelSpeed()
    {
        var car = new Car();

        car.EngineStart();

        Enumerable.Range(0, 10).ToList().ForEach(s => car.Accelerate(100));

        Assert.AreEqual(100, car.drivingInformationDisplay.ActualSpeed, "Wrong actual speed!");

        car.FreeWheel();
        car.FreeWheel();
        car.FreeWheel();

        Assert.AreEqual(97, car.drivingInformationDisplay.ActualSpeed, "Wrong actual speed!");
    }

    [Test]
    public void TestAccelerateBy10()
    {
        var car = new Car();

        car.EngineStart();

        Enumerable.Range(0, 10).ToList().ForEach(s => car.Accelerate(100));

        car.Accelerate(160);
        Assert.AreEqual(110, car.drivingInformationDisplay.ActualSpeed, "Wrong actual speed!");
        car.Accelerate(160);
        Assert.AreEqual(120, car.drivingInformationDisplay.ActualSpeed, "Wrong actual speed!");
        car.Accelerate(160);
        Assert.AreEqual(130, car.drivingInformationDisplay.ActualSpeed, "Wrong actual speed!");
        car.Accelerate(160);
        Assert.AreEqual(140, car.drivingInformationDisplay.ActualSpeed, "Wrong actual speed!");
        car.Accelerate(145);
        Assert.AreEqual(145, car.drivingInformationDisplay.ActualSpeed, "Wrong actual speed!");
    }
    
    [Test]
    public void ShouldNotAccelerateIfCarNotStarted()
    {
        var car = new Car();

        Enumerable.Range(0, 10).ToList().ForEach(s => car.Accelerate(100));

        car.Accelerate(160);
        Assert.AreNotEqual(110, car.drivingInformationDisplay.ActualSpeed, "Wrong actual speed!");
        car.Accelerate(160);
        Assert.AreNotEqual(120, car.drivingInformationDisplay.ActualSpeed, "Wrong actual speed!");
    }

    [Test]
    public void TestBraking()
    {
        var car = new Car();

        car.EngineStart();

        Enumerable.Range(0, 10).ToList().ForEach(s => car.Accelerate(100));

        car.BrakeBy(20);

        Assert.AreEqual(90, car.drivingInformationDisplay.ActualSpeed, "Wrong actual speed!");

        car.BrakeBy(10);

        Assert.AreEqual(80, car.drivingInformationDisplay.ActualSpeed, "Wrong actual speed!");
    }

    [Test]
    public void TestConsumptionSpeedUpTo30()
    {
        var car = new Car(1, 20);

        car.EngineStart();

        car.Accelerate(30);
        car.Accelerate(30);
        car.Accelerate(30);
        car.Accelerate(30);
        car.Accelerate(30);
        car.Accelerate(30);
        car.Accelerate(30);
        car.Accelerate(30);
        car.Accelerate(30);
        car.Accelerate(30);

        Assert.AreEqual(0.98, car.fuelTankDisplay.FillLevel, "Wrong fuel tank fill level!");
    }
}