using System;

namespace _10.CarSalesman
{
    public class Car
    {
        private string model;
        private Engine engine;
        private double? weight;
        private string color;

        public Car(string model, Engine engine)
        {
            this.model = model;
            this.engine = engine;
        }

        public int Weight
        {
            set { this.weight = value; }
        }

        public string Color
        {
            set { this.color = value; }
        }

        public override string ToString()
        {
            var result = string.Concat($"{this.model}:", Environment.NewLine, this.engine.ToString());
            
            if (this.weight == null)
            {
                result = string.Concat(result, "  Weight: n/a", Environment.NewLine);
            }
            else
            {
                result = string.Concat(result, $"  Weight: {this.weight}", Environment.NewLine);
            }
            if (this.color == null)
            {
                result = string.Concat(result, "  Color: n/a", Environment.NewLine);
            }
            else
            {
                result = string.Concat(result, $"  Color: {this.color}", Environment.NewLine);
            }

            return result;
        }
    }
}