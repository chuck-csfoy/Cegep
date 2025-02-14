namespace Exercice3b
{
    internal class Rectangle
    {
        private int height;
        private int width;

        //Constructor
        public Rectangle(int height, int width)
        {
            this.Height = height;
            this.Width = width;
        }

        //Access modifier
        //Members declared as "public" can be accessed from anywhere in the program, including other classes.
        public int Height
        {
            get { return height; }
            set { 
                if (value >= 0)
                {
                    height = value;
                }
                if (value < 0)
                {
                    throw new ArgumentException("Object height value cannot be negative");
                }
            }
        }

        //Access modifier
        public int Width
        {
            get { return width; }
            set {
                if (value >= 0)
                {
                    width = value;
                }
                if (value < 0)
                {
                    throw new ArgumentException("Object width value cannot be negative");
                }

            }
        }

        // area = this.height * this.width;
        public int CalculateArea()
        {
            int area;

            area = Height * Width;

            return area;

        }

        // peremeter = 2*this.height + 2*this.width;
        public int CalculatePeremeter()
        {
            int peremeter;

            peremeter = (2 * Height) + (2 * Width);

            return peremeter;
        }
    }
}
