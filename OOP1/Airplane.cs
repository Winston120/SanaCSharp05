﻿using System;
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
            StartDate= new Date(airplane.StartDate);
            FinishDate= new Date(airplane.FinishDate);
        }
        public string GetStartCity()
        {
            return StartCity;
        }
        public void SetStartCity(string startCity)
        {
            StartCity = startCity;
        }
        public string GetFinishCity()
        {
            return FinishCity;
        }
        public void SetFinishCity(string finishCity)
        {
            FinishCity = finishCity;
        }
        public string GetStartDate()
        {
            return $"Час вирушеня - {StartDate.GetDate()}";
        }
        public void SetStartDate(Date date)
        {
            StartDate = new Date(date);
        }
        public string GetFinishDate()
        {
            return $"Час прибуття - {FinishDate.GetDate()}";
        }
        public void SetFinishDate(Date date)
        {
            FinishDate = new Date(date);
        }

        public string GetTotalTime()
        {
            DateTime date1 = new DateTime(StartDate.GetYear(), StartDate.GetMonth(), StartDate.GetDay(), StartDate.GetHours(), StartDate.GetMinutes(), 0);
            DateTime date2 = new DateTime(FinishDate.GetYear(), FinishDate.GetMonth(), FinishDate.GetDay(), FinishDate.GetHours(), FinishDate.GetMinutes(), 0);
            TimeSpan res = date2 - date1;
            return $"Сумарний час подорожі - {res.TotalMinutes} хв.";
        }
        public bool IsArrivingToday()
        {
            if(StartDate.GetDay() == FinishDate.GetDay()) return true ;
            else return false ;
        }
    }

}
