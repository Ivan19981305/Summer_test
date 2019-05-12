using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summer_test
{
    class Aircraft : Air_vehicle
    {
        public Aircraft(double speed, double capacity) : base(speed, capacity, "не известно", -1, -1) { }
        public override void Print()
        {
            Console.WriteLine("Тип транспорта: самолёт");
            base.Print();
        }
    }
    class Helicopter : Air_vehicle
    {
        public Helicopter(double speed, double capacity) : base(speed, capacity, "не известно", -1, -1) { }
        public override void Print()
        {
            Console.WriteLine("Категория транспорта: вертолёт");
            base.Print();
        }
    }

    class Car : Ground_vehicle
    {
        public Car(double speed, double capacity) : base(speed, capacity, "не известно", -1, -1) { }
        public override void Print()
        {
            Console.WriteLine("Категория транспорта: автомобиль");
            base.Print();
        }
    }
    class Train : Ground_vehicle
    {
        public Train(double speed, double capacity) : base(speed, capacity, "не известно", -1, -1) { }
        public override void Print()
        {
            Console.WriteLine("Категория транспорта: поезд");
            base.Print();
        }
    }
    class Tanker : Water_vehicle
    {
        public Tanker(double speed, double capacity) : base(speed, capacity, "не известно", -1, -1) { }
        public override void Print()
        {
            Console.WriteLine("Категория транспорта: танкер");
            base.Print();
        }
    }
    class Liner : Water_vehicle
    {
        public Liner(double speed, double capacity) : base(speed, capacity, "не известно", -1, -1) { }
        public override void Print()
        {
            Console.WriteLine("Категория транспорта: лайнер");
            base.Print();
        }
    }
    abstract class Water_vehicle : Vehicle //водный вид транспорта
    {
        public override void Print()
        {
            Console.WriteLine("Вид транспорта: водный");
            base.Print();
        }
        public Water_vehicle(double speed, double capacity, string brand, int staff_count, int passenger_count) : base(speed, capacity, brand, staff_count, passenger_count) { }
    }
    abstract class Air_vehicle : Vehicle //воздушный вид транспорта
    {
        public override void Print()
        {
            Console.WriteLine("Вид транспорта: воздушный");
            base.Print();
        }
        public Air_vehicle(double speed, double capacity, string brand, int staff_count, int passenger_count) : base(speed, capacity, brand, staff_count, passenger_count) { }
    }
    abstract class Ground_vehicle : Vehicle //наземный вид транспорта
    {
        public override void Print()
        {
            Console.WriteLine("Вид транспорта: наземный");
            base.Print();
        }
        public Ground_vehicle(double speed, double capacity, string brand, int staff_count, int passenger_count) : base(speed, capacity, brand, staff_count, passenger_count) { }
    }
    abstract class Vehicle
    {
        public double speed; //скорость
        public double capacity; //грузоподъёмность
        public string brand; //марка
        public int staff_count; //число персонала
        public int passenger_count; //число пассажиров

        public void delivering_process() { } //процесс доставки груза

        //конструктор:
        public Vehicle(double speed, double capacity, string brand, int staff_count, int passenger_count)
        {
            this.speed = speed;
            this.capacity = capacity;
            this.brand = brand;
            this.staff_count = staff_count;
            this.passenger_count = passenger_count;
        }

        public virtual void Print()
        {
            Console.WriteLine($"Скорость: {speed}");
            Console.WriteLine($"Грузоподъёмность: {capacity}");
            Console.WriteLine($"Марка {brand}");
            Console.WriteLine($"Число персонала {staff_count}");
            Console.WriteLine($"Число пассажиров {passenger_count}");
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите скорости и грузоподъёмности для всех категорий по одной величине в строке.");

            Console.WriteLine("Введите скорость и грузоподъёмность лайнера");
            Liner a = new Liner(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));

            Console.WriteLine("Введите скорость и грузоподъёмность танкера");
            Tanker b = new Tanker(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));

            Console.WriteLine("Введите скорость и грузоподъёмность автомобиля");
            Car c = new Car(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));

            Console.WriteLine("Введите скорость и грузоподъёмность поезда");
            Train d = new Train(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));

            Console.WriteLine("Введите скорость и грузоподъёмность самолёта");
            Aircraft e = new Aircraft(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));

            Console.WriteLine("Введите скорость и грузоподъёмность вертолёта");
            Helicopter f = new Helicopter(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));

            a.Print();
            b.Print();
            c.Print();
            d.Print();
            e.Print();
            f.Print();

            Console.ReadKey();
        }
    }
}
