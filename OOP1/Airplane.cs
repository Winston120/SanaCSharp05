using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Airplane
    {
        protected string StartCity;
        protected string FinishCity;
        protected Date StartDate;
        protected Date FinishDate;
        
        public Airplane()/*Замовчуванню*/
        {
            StartCity = "Kyiv";
            FinishCity = "Budapest";
            StartDate= new Date();
            FinishDate = new Date();
        }
        public Airplane(string startCity, string finishCity, Date startDate, Date finisDate)
        {
            StartCity = startCity;
            FinishCity = finishCity;
            StartDate = new Date(startDate);
            FinishDate = new Date(finisDate);
        }
        public Airplane(Date startDate, Date finisDate)
        {
            StartCity = "Kyiv";
            FinishCity = "Budapest";
            StartDate = new Date(startDate);
            FinishDate = new Date(finisDate);
        }
        public Airplane(Airplane airplane)/*Копіювання*/
        {
            StartCity= airplane.StartCity;
            FinishCity= airplane.FinishCity;
            StartDate= new Date(StartDate);
            FinishDate= new Date(FinishDate);
        }
    }

}
