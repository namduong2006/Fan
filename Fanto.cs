using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fan
{
    internal class Fanto
    {
        public const int SLOW = 1;
        public const int MEDIUMW = 2;
        public const int FAST = 3;
        private int speed = SLOW;
        public int Speed { get => speed; set => speed = value; }
        private bool on = false;
        public bool On { get => on; set => on = value; }
        private double radius = 5;
        public double Radius { get => radius; set => radius = value; }
        private string color = "blue";
        public string Color { get => color; set => color = value; }

        
        public Fanto() 
        {
            
        }
        public Fanto(bool On, int Speed, double Radius, string Color)
        {
            this.Speed = Speed;
            this.On = On;
            this.Radius = Radius;
            this.Color = Color;
        }
        public virtual void ToString()
        {
            if (On == false)
            { Console.WriteLine($"fan is off:Speed={this.Speed=Speed},Radius={this.Radius = Radius},Color={this.Color = Color}");}
            if (On == true)
            { Console.WriteLine($"fan is on:Speed={this.Speed = Speed},Radius={this.Radius = Radius},Color={this.Color = Color}") ; }
        }
    }
    
}
