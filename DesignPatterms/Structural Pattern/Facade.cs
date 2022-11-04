using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterms.Structural_Pattern
{
    public class CarBody
    {
        public void SetCarBody()
        {
            Console.WriteLine("Car Body");
        }
    }

    public class CarEngine
    {
        public void SetCarEngine()
        {
            Console.WriteLine("Car Engine");
        }
    }

    public class CarPaint
    {
        public void SetCarPaint()
        {
            Console.WriteLine("Car Paint");
        }
    }

    public class CarFacade
    {
        CarBody Body;
        CarEngine Engine;
        CarPaint Paint;

        public CarFacade()
        {
            Body = new CarBody();
            Engine = new CarEngine();
            Paint = new CarPaint();
        }

        public void CreateCompleteCar()
        {
            Body.SetCarBody();
            Engine.SetCarEngine();
            Paint.SetCarPaint();
        }
    }

    public class Client
    {
        public static void Run()
        {
            CarFacade car = new CarFacade();
            car.CreateCompleteCar();
        }
    }
}
