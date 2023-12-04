using BuilderPattern;

namespace BuilderPattern
{

    public class Engine
    {

    }
    public interface Builder
    {
        public void reset();

        public void set_seats(int number);

        public void set_engine(Engine engine);

        public void set_tripcomputer();


        public void set_GPS();


    }
    //-------------------------------------------------------------------------------
    public class Director
    {
        public Director()
        {

        }
        public void makeSUV(Builder builder)
        {
            Console.WriteLine("Make SUV");
        }
        public void makeSPORT(Builder builder)
        {
            Console.WriteLine("Make Sport car");
        }
    }

    //-------------------------------------------------------------------------------
    public class CarBuilder : Builder
    {

        private Car car = new Car();


        public Car getResult()
        {
            return this.car;
        }

        public void reset()
        {
            Console.WriteLine("reset(Car Builder)");
        }

        public void set_engine(Engine engine)
        {
            Console.WriteLine("set_engine(Car Builder)");
        }

        public void set_GPS()
        {
            Console.WriteLine("set_GPS(Car Builder)");
        }

        public void set_seats(int number)
        {
            Console.WriteLine("set_seats(Car Builder)");
        }

        public void set_tripcomputer()
        {
            Console.WriteLine("set_tripcomputer(Car Builder)");
        }
    }

    public class Car
    {
        public Car()
        {
        }
    }


    //-------------------------------------------------------------------------------
    public class CarManualBuilder : Builder
    {
        private ManualCar manual = new ManualCar();
        public void reset()
        {
            Console.WriteLine("reset(CarManual Builder)");
        }

        public void set_engine(Engine engine)
        {
            Console.WriteLine("set_engine(CarManual Builder)");
        }

        public void set_GPS()
        {
            Console.WriteLine("set_GPS(CarManual Builder)");
        }

        public void set_seats(int number)
        {
            Console.WriteLine("set_seats(CarManual Builder)");
        }

        public void set_tripcomputer()
        {
            Console.WriteLine("set_tripcomputer(CarManual Builder)");
        }
        public ManualCar getResult()
        {
            return this.manual;
        }
    }

    public class ManualCar
    {
        public ManualCar()
        {
        }
    }



    //Client
    class Program
    {
        static void Main()
        {
            Director director = new();
            CarBuilder builder = new CarBuilder();
            director.makeSPORT(builder);
            Car car = builder.getResult();
        }
    }
}



