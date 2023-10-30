using System;
using System.Runtime.InteropServices;

namespace Lab2Classes
{
    public sealed class Tablet : Computer
    {
        private double _displaySize;//размер экрана
        private int _updateRate;//частора обновления
        public override string ToString()//переводит в строку
        {
            return $"{GetType()}: {Article} {Name} {Producer} {Model} {Color} {Processor} {VideoChips} {Ram} {Memory} {_displaySize} {_updateRate} {Price}";
        }

        public override bool Equals(object obj)//проверяет равенство
        {
            if (obj == null || !(obj is Tablet)) return false;
            else
            {
                var tablet = (Tablet)obj;
                if (this.Article != tablet.Article) return false;
                if (this.Color != tablet.Color) return false;
                if (this.Description != tablet.Description) return false;
                if (Math.Abs(this.Memory - tablet.Memory) > 0.0001) return false;
                if (this.Model != tablet.Model) return false;
                if (this.Name != tablet.Name) return false;
                if (this.Price != tablet.Price) return false;
                if (this.Processor != tablet.Processor) return false;
                if (this.Producer != tablet.Producer) return false;
                if (this.Ram != tablet.Ram) return false;
                if (this.VideoChips != tablet.VideoChips) return false;
                if (Math.Abs(this._displaySize - tablet.DisplaySize) > 0.0001) return false;
                if (this.UpdateRate != tablet.UpdateRate) return false;
                return true;
            }
        }

        public override int GetHashCode()
        {
            return $"{GetType()}: {Article} {Name} {Producer} {Model} {Color} {Processor} {VideoChips} {Ram} {Memory} {_displaySize} {_updateRate} {Price}".GetHashCode();
        }

        public override void Action()//имитирует работу планшета
        {
            Console.WriteLine($"{Producer + Model}: Swipe to start work");
            Console.WriteLine($"{Producer + Model}: Tablet ready to work");
        } 
        public Tablet():base()
        {
            _displaySize = 0;
            _updateRate = 0;
            Name = "Tablet";
        }

        public Tablet(string name, string article, string description, decimal price, string producer, string model, string color, string processor, string videoChips, int ram, double memory, double displaySize, int updateRate) : base(name, article, description, price, producer, model, color, processor, videoChips, ram, memory)
        {
            _displaySize = displaySize;
            _updateRate = updateRate;
        }

        public double DisplaySize
        {
            get => _displaySize;
            set => _displaySize = value;
        }

        public int UpdateRate
        {
            get => _updateRate;
            set => _updateRate = value;
        }
    }
}