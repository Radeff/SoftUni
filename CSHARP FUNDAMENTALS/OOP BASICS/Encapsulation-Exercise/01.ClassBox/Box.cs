namespace _01.ClassBox
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public double Length
        {
            get { return this.length; }
            set { this.length = value; }
        }

        public double Width
        {
            get { return this.width; }
            set { this.width = value; }
        }

        public double Height
        {
            get { return this.height; }
            set { this.height = value; }
        }

        public double SurfaceArea()
        {
            return 2.0 * length * width + 2.0 * length * height + 2.0 * width * height;
        }

        public double LateralArea()
        {
            return 2.0 * length * height + 2.0 * width * height; 
        }

        public double Volume()
        {
            return length * width * height;
        }

        public Box(double length, double width, double height)
        {
            this.Height = height;
            this.Length = length;
            this.Width = width;
        }
    }
}