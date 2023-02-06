using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Currency
    {
        protected string Name;
        protected double ExRate;

        public Currency()
        {
            Name = "Dollar";
            ExRate= 37.43;
        }
        public Currency(string name, double exRate)
        {
            Name = name;
            ExRate = exRate;
        }
        public Currency(Currency currency)
        {
            Name = currency.Name;
            ExRate= currency.ExRate;
        }
        public string GetName()
        {
            return Name;
        }
        public void SetName(string name)
        {
            if(name.Length>3) Name = name;
        }
        public double GetExRate()
        {
            return ExRate;
        }
        public void SetExRate(double exRate)
        {
            ExRate = exRate;
        }

        public string GetFullCurrtncy()
        {
            return $"{Name} - {ExRate}";
        }
    }
}
