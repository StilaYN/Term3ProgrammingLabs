using System;
using System.Collections.Generic;

namespace Lab2Classes
{
    public abstract class Computer : Technic
    {
        private string _processor;//процессор
        private string _videoChips;//графический чип
        private int _ram;//оперативная память 
        private double _memory;//встроенная память

        protected Computer():base()
        {
            _processor = "None";
            _videoChips = "None";
            _ram = 0;
            _memory = 0;
            Name = "computer";
        }

        protected Computer(string name, string article, string description, decimal price, string producer, string model, string color, string processor, string videoChips, int ram, double memory) : base(name, article, description, price, producer, model, color)
        {
            _processor = processor;
            _videoChips = videoChips;
            _ram = ram;
            _memory = memory;
        }

        public string Processor
        {
            get => _processor;
            set => _processor = value;
        }

        public string VideoChips
        {
            get => _videoChips;
            set => _videoChips = value;
        }

        public int Ram
        {
            get => _ram;
            set => _ram = value;
        }

        public double Memory
        {
            get => _memory;
            set => _memory = value;
        }
    }
}