using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClassClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Phone phone = new Phone();
            Phone anotherPhone = new Phone(1234251, "Android", "Silver");
            phone.Number = 262444112;
            phone.Manufacturer = "Apple";
            phone.Color = "Black";

        }

    }
    public class Phone
    {
        //properties
        public int Number { get; set; }
        public string Manufacturer { get; set; }
        public string Color { get; set; }

        public string Model { get; set; }
        public Phone()
        {
            Number = 262444112;
            Manufacturer = "Apple";
            Color = "Black";
        }
        public Phone(int number, string manu, string color)
        {
            Number = number;
            Manufacturer = manu;
            Color = color;
        }
        public void MakeCall() 
        {
            
        }
        public void SendText()
        {
    
        }

        public void TakePicture()
        {

        }

        //Can't have the same signature... (int, string, string)
        //public Phone(int number, string manu, string model)
        //{
        //    Number = number;
        //    Manufacturer = manu;
        //    Model = model;
        //}
    }

}
