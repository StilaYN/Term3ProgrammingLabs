﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Classes
{
    public abstract class Goods
    {
        private string _name;//имя
        private string _article;//артикул
        private string _description;//описание
        private decimal _price;//цена

        public virtual void Action()//имитирует действие товара
        {

        }
        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public string Article
        {
            get => _article;
            set => _article = value;
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

        protected Goods()
        {
            _name = "Noname";
            _article = "#0000";
            _description = "None";
            _price = 0;
        }

        protected Goods(string name, string article, string description, decimal price)
        {
            _name = name;
            _article = article;
            _description = description;
            _price = price;
        }
    }
}
