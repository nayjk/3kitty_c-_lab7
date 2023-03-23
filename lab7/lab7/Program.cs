namespace lab7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KiaRio Kia = new KiaRio(50, 60, 8000);
            Kia.consolekia();
            Boeing Boeing = new Boeing(60, 40, 9573);
            Boeing.consoleboeing();
            Titanic Titanic = new Titanic(485, 274, 79592);
            Titanic.consoleTitanic();
        }
    }

    abstract class Transport
    {
        public abstract int speed { get; set; }
        public abstract int loadcapacity { get; set; } //грузоподъёмность
        public abstract int distancerange { get; set; } // дальность расстояния
        protected Transport(int speed, int loadcapacity, int distancerange)
        {
            this.speed = speed;
            this.loadcapacity = loadcapacity;
            this.distancerange = distancerange;
        }

        public void console()
        {
            Console.WriteLine("Транспорт движется со скоростью " + speed);
            Console.WriteLine("Грузоподъёмность: " + loadcapacity);
            Console.WriteLine("Дальность расстояния: " + distancerange);
        }
    }

    abstract class Auto : Transport
    {
        public override int speed { get; set; }
        public override int loadcapacity { get; set; } //грузоподъёмность
        public override int distancerange { get; set; } // дальность расстояния
        protected Auto(int speed, int loadcapacity, int distancerange) : base(speed, loadcapacity, distancerange)
        {

        }
    }

    class KiaRio : Auto
    {
        public KiaRio(int speed, int loadcapacity, int distancerange) : base(speed, loadcapacity, distancerange)
        {

        }

        public void consolekia()
        {
            Console.WriteLine("Киа Рио грузоподъёмностью " + loadcapacity + ", скоростью " + speed + " и дальностью расстояния " + distancerange);
        }
    }

    abstract class Airplane : Transport
    {
        public override int speed { get; set; }
        public override int loadcapacity { get; set; } //грузоподъёмность
        public override int distancerange { get; set; } // дальность расстояния
        protected Airplane(int speed, int loadcapacity, int distancerange) : base(speed, loadcapacity, distancerange)
        {

        }
    }

    class Boeing : Airplane
    {
        public Boeing(int speed, int loadcapacity, int distancerange) : base(speed, loadcapacity, distancerange)
        {

        }
         public void consoleboeing()
        {
            Console.WriteLine("Боенг грузоподъёмностью " + loadcapacity + ", скоростью " + speed + " и дальностью расстояния " + distancerange);
        }
    }

    abstract class Ship : Transport
    {
        public override int speed { get; set; }
        public override int loadcapacity { get; set; } //грузоподъёмность
        public override int distancerange { get; set; } // дальность расстояния
        protected Ship(int speed, int loadcapacity, int distancerange) : base(speed, loadcapacity, distancerange)
        {

        }
    }

    class Titanic : Ship
    {
        public Titanic(int speed, int loadcapacity, int distancerange) : base(speed, loadcapacity, distancerange)
        {

        }

        public void consoleTitanic()
        {
            Console.WriteLine("Титаник грузоподъёмностью " + loadcapacity + ", скоростью " + speed + " и дальностью расстояния " + distancerange + " утонул)))");
        }
    }
}