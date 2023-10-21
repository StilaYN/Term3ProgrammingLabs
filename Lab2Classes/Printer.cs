namespace Lab2Classes
{
    public class Printer : Technic
    {
        private PrinterType _type;
        private int _speedPrintedPapersPerMinute;

        public Printer():base()
        {
            _type = PrinterType.None;
            _speedPrintedPapersPerMinute = 0;
            Name = "Printer";
        }

        public Printer(string name, string article, string description, decimal price, string producer, int voltage, string model, string color, PrinterType type, int speedPrintedPapersPerMinute) : base(name, article, description, price, producer, voltage, model, color)
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