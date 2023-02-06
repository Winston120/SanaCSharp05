using Microsoft.VisualBasic;
using OOP1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Date
    {
        protected int Year;
        protected int Month;
        protected int Day;
        protected int Hours;
        protected int Minutes;
        public Date()/*По замовчуванню*/
        {
            Year = 2023;
            Month = 2;
            Day = 3;
            Hours = 9;
            Minutes = 54;
        }
        public Date(int year, int month, int day, int hours, int minutes)
        {
            Year = year;
            Month = month;
            Day = day;
            Hours = hours;
            Minutes = minutes;
        }
        public Date(int year, int month, int day, int hours)
        {
            Year = year;
            Month = month;
            Day = day;
            Hours = hours;
            Minutes = 0;
        }
        public Date (Date date)/*Копіювання*/
        {
            Year = date.Year;
            Month = date.Month;
            Day = date.Day;
            Hours = date.Hours;
            Minutes = date.Minutes;
        }
        public int GetYear()
        {
            return Year;
        }
        public void SetYear(int year)
        {
            if(year > 1980) Year = year;
        }
        public int GetMonth()
        {
            return Month;
        }
        public void SetMonth(int month)
        {
            if(month>0 && month<=12) Month = month;
        }
        public int GetDay()
        {
            return Day;
        }
        public void SetDay(int day)
        {
            if(day>0 && day<=31) Day = day;
        }
        public int GetHours()
        {
            return Hours;
        }
        public void SetHours(int hours)
        {
            if(hours>=0 && hours<24) Hours = hours;
        }
        public int GetMinutes()
        {
            return Minutes;
        }
        public void SetMinutes(int minutes)
        {
            if(minutes>=0 && minutes<60) Minutes = minutes;
        }
        public string GetDate()
        {
            return $"{Day}.{Month}.{Year} {Hours}:{Minutes}";
        }
    }
   
}
