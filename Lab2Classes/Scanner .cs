namespace Lab2Classes
{
    public class Scanner : Technic
    {
        private ScannerType _type;
        private int _dpi;

        public Scanner():base()
        {
            _type = ScannerType.None;
            _dpi = 0;
            Name = "Scanner";

        }

        public Scanner(string name, string article, string description, decimal price, string producer, int voltage, string model, string color, ScannerType type, int dpi) : base(name, article, description, price, producer, voltage, model, color)
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