namespace Lab2Classes
{
    public abstract class Technic : Goods
    {
        private string _producer;
        private int _voltage;
        private string _model;
        private string _color;

        protected Technic():base()
        {
            _producer = "None";
            _voltage = 220;
            _model = "None";
            _color = "None";
        }

        protected Technic(string name, string article, string description, decimal price, string producer, int voltage, string model, string color) : base(name, article, description, price)
        {
            _producer = producer;
            _voltage = voltage;
            _model = model;
            _color = color;
        }

        public string Producer
        {
            get => _producer;
            set => _producer = value;
        }

        public int Voltage
        {
            get => _voltage;
            set => _voltage = value;
        }

        public string Model
        {
            get => _model;
            set => _model = value;
        }

        public string Color
        {
            get => _color;
            set => _color = value;
        }

    }
}