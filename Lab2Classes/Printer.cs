using System;

namespace Lab2Classes
{
    public class Printer : Technic
    {
        private PrinterType _type;//тип принтера
        private int _speedPrintedPapersPerMinute;//скорость печати
        public override string ToString()//перевод в строку
        {
            return $"{GetType()}: {Article} {Name} {Producer} {Model} {Color} {EnumToString.PrinterTypeToString(_type)} {_speedPrintedPapersPerMinute} {Price}";
        }

        public override void Action()//имитирует работу принтера 
        {
            Console.WriteLine($"{Producer + Model}: Page is being printed");
            Console.WriteLine($"{Producer + Model}: Page was printed");
        }
        public Printer():base()
        {
            _type = PrinterType.None;
            _speedPrintedPapersPerMinute = 0;
            Name = "Printer";
        }

        public Printer(string name, string article, string description, decimal price, string producer, string model, string color, PrinterType type, int speedPrintedPapersPerMinute) : base(name, article, description, price, producer, model, color)
        {
            _type = type;
            _speedPrintedPapersPerMinute = speedPrintedPapersPerMinute;
        }

        public PrinterType Type
        {
            get => _type;
            set => _type = value;
        }

        public int SpeedPrintedPapersPerMinute
        {
            get => _speedPrintedPapersPerMinute;
            set => _speedPrintedPapersPerMinute = value;
        }
    }
}