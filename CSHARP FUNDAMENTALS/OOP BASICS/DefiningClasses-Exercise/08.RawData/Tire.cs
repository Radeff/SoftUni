﻿namespace _08.RawData
{
    public class Tire
    {
        private int age;
        private double pressure;

        public Tire(int age, double pressure)
        {
            this.age = age;
            this.pressure = pressure;
        }

        public double Pressure
        {
            get { return this.pressure; }
        }
    }
}