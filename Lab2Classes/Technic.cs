using System;

namespace Lab2Classes
{
    public abstract class Technic : Goods
    {
        private string _producer;
        private string _model;
        private string _color;

        protected Technic():base()
        {
            _producer = "None";
            _model = "None";
            _color = "None";
        }

        protected Technic(string name, string article, string description, decimal price, string producer, string model, string color) : base(name, article, description, price)
        {
            _producer = producer;
            _model = model;
            _color = color;
        }

        public string Producer
        {
            get => _producer;
            set => _producer = value;
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