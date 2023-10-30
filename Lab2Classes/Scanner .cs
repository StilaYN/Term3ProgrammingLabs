using System;

namespace Lab2Classes
{
    public class Scanner : Technic
    {
        private ScannerType _type;//тип сканнера
        private int _dpi;//разрешение сканнера
        public override string ToString()//перевод в строку
        {
            return $"{GetType()}: {Article} {Name} {Producer} {Model} {Color} {EnumToString.ScannerTypeToString(_type)} {_dpi} {Price}";
        }
        public override void Action()//имитирует работу принтера
        {
            Console.WriteLine($"{Producer + Model}: Page is being scanned");
            Console.WriteLine($"{Producer + Model}: Page was scanned");
        }
        public Scanner():base()
        {
            _type = ScannerType.None;
            _dpi = 0;
            Name = "Scanner";

        }

        public Scanner(string name, string article, string description, decimal price, string producer, string model, string color, ScannerType type, int dpi) : base(name, article, description, price, producer, model, color)
        {
            _type = type;
            _dpi = dpi;
        }

        public ScannerType Type
        {
            get => _type;
            set => _type = value;
        }

        public int Dpi
        {
            get => _dpi;
            set => _dpi = value;
        }
    }

}