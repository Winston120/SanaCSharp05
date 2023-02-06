using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Product
    {
        protected string Name;
        protected double Price;
        protected Currency Cost;
        protected int Quantity;
        protected string Producer;
        protected double Weight;

        public Product() 
        {
            Name = "Undefined";
            Price = 0;
            Cost = new Currency();
            Quantity= 0;
            Producer = "Undefined";
            Weight= 0;
        }
        public Product(string name, double price, Currency cost, int quantity, string producer, double weight)
        {
            Name = name;
            Price = price;
            Cost = new Currency(cost);
            Quantity = quantity;
            Producer = producer;
            Weight = weight;
        }
        public Product(string name, double price, Currency cost, int quantity, string producer)
        {
            Name = name;
            Price = price;
            Cost = new Currency(cost);
            Quantity = quantity;
            Producer = producer;
            Weight = 0;
        }
        public Product(string name, double price, int quantity, string producer, double weight)
        {
            Name = name;
            Price = price;
            Cost = new Currency();
            Quantity = quantity;
            Producer = producer;
            Weight = weight;
        }
        public Product(Product product)
        {
            Name = product.Name;
            Price = product.Price;
            Cost = new Currency(product.Cost);
            Quantity = product.Quantity;
            Producer = product.Producer;
            Weight = product.Weight;
        }
        public string GetName() { return Name; }
        public void SetName(string name)
        {
            if(name.Length > 3) Name = name;
        }
        public double GetPrice() { return Price; }
        public void SetPrice(double price) { Price = price; }
        public string GetCost()
        {
            return $"{Cost.GetFullCurrtncy()}";
        }
        public void SetCost(Currency cost)
        {
            Cost = new Currency(cost);
        }
        public int GetQuantity() { return Quantity; }
        public void SetQuantity(int quantity) { Quantity= quantity; }
        public string GetProducer() { return Producer;}
        public void SetProducer(string producer) { Producer= producer;}
        public double GetWeight() { return Weight; }
        public void SetWeight(double weight) { Weight= weight; }

        public string GetPriceInUAH()
        {
            double res = Price * Cost.GetExRate();
            return $"Ціна одиниці товару - {res} грн.";
        }
        public string GetTotalPriceInUAH()
        {
            double res = Price * Cost.GetExRate() * Quantity;
            return $"Загальна вартість усіх наявних на складі товарів даного виду - {res} грн.";
        }

    }
}
