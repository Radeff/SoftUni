namespace _07.SpeedRacing
{
    public class Car
    {
        private string model;
        private double fuelAmount;
        private double fuelConsumptionForKm;
        private double distanceTravelled;

        public string Model
        {
            get { return this.model; }
        }

        public double FuelAmount
        {
            get { return this.fuelAmount; }
            set { this.fuelAmount = value; }
        }

        public double FuelConsumptionForKm
        {
            get { return this.fuelConsumptionForKm; }
        }

        public double DistanceTravelled
        {
            get { return this.distanceTravelled; }
            set { this.distanceTravelled = value; }
        }

        public Car(string model, double fuelAmount, double fuelConsumptionForKm)
        {
            this.model = model;
            this.fuelAmount = fuelAmount;
            this.fuelConsumptionForKm = fuelConsumptionForKm;
            this.distanceTravelled = 0.0;
        }

        public void Drive(double km)
        {
            var fuelNeeded = km * this.fuelConsumptionForKm;

            if (this.fuelAmount < fuelNeeded)
            {
                System.Console.WriteLine("Insufficient fuel for the drive");
                return;
            }

            this.fuelAmount -= fuelNeeded;
            this.distanceTravelled += km;
        }
    }
}
