using System;

namespace _10.CarSalesman
{
    public class Engine
    {
        private string model;
        private int power;
        private int? displacement;
        private string efficiency;

        public Engine(string model, int power)
        {
            this.model = model;
            this.power = power;
        }

        public string Model
        {
            get { return this.model; }
        }

        public int Displacement
        {
            set { this.displacement = value; }
        }

        public string Efficiency
        {
            set { this.efficiency = value; }
        }

        public override string ToString()
        {
            var result = string.Concat($"  {this.model}:", Environment.NewLine, $"    Power: {this.power}", Environment.NewLine);
            if (this.displacement == null)
            {
                result = string.Concat(result, "    Displacement: n/a", Environment.NewLine);
            }
            else
            {
                result = string.Concat(result, $"    Displacement: {this.displacement}", Environment.NewLine);
            }
            if (this.efficiency == null)
            {
                result = string.Concat(result, "    Efficiency: n/a", Environment.NewLine);
            }
            else
            {
                result = string.Concat(result, $"    Efficiency: {this.efficiency}", Environment.NewLine);
            }

            return result;
        }
    }
}
