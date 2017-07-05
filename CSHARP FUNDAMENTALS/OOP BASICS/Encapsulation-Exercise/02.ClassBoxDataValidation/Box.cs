using System;

namespace _02.ClassBoxDataValidation
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public double Length
        {
            get
            {
                return this.length;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Length cannot be zero or negative.");
                }
                this.length = value;
            }
        }

        public double Width
        {
            get
            {
                return this.width;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }
                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height cannot be zero or negative.");
                }
                this.height = value;
            }
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
