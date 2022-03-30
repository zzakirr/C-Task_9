using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Employee
    {
        private string _name;
        private string _surname;
        private int _salary;

        public string Name 
        {
            get { return _name; }
            set
            {
                int count = 0;
                foreach (var item in value)
                {
                    if(char.IsLetter(item))
                    {
                        count++;
                    }
                }
                if(char.IsUpper(value[0]) && count==value.Length)
                {
                    _name = value;
                }
            }
        }
        public string Surname
        {
            get { return _surname; }
            set
            {
                int count = 0;
                foreach (var item in value)
                {
                    if (char.IsLetter(item))
                    {
                        count++;
                    }
                }
                if (char.IsUpper(value[0]) && count == value.Length)
                {
                    _surname = value;
                }
            }
        }
        public int Salary 
        {
            get { return _salary; }
            set
            {
                if (value >= 250)
                {
                    _salary = value;
                }
            }
        }
       
       

    }
}
