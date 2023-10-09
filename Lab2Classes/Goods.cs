using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Classes
{
    abstract class Goods
    {
        private string _name;
        private string _description;
        private decimal _price;
        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public string Description
        {
            get => _description;
            set => _description = value;
        }

        public decimal Price
        {
            get => _price;
            set => _price = value;
        }

        public Goods(string name, string description, decimal price)
        {
            _name = name;
            _description = description;
            _price = price;
        }
    }
}
