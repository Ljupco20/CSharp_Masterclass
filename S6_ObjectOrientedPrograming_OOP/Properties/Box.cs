using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    internal class Box
    {
        //member variable
        private int length;
        private int height;
        private int width;
        private int volume;
     

        public int FrontSurface
        {
            get
            {
                return this.height * this.length;
            }
           
        }
        public int Volume
        {
            get
            {
                return this.length * this.height * this.width;
            }
        }
        //auto - implemented property - enter "prop" + press double tab
       public int Width { get; set; }

        /*
        public int Width 
        { get
            {
                return this.width;
            } set
            {
                this.width = value;
            } 
        
        }
         */
        public int Height
        {
            get { return height; }
            set 
            { 
                if(value < 0)
                {
                    height = -value;
                }
                height = value; 
            }
        }
        public Box(int length, int height, int width)
        {
            this.length = length;
            this.height = height;
            Width = width;
        }

        public void SetLength(int length)
        {
            if(length < 0)
            {
                throw new Exception("Number should be positive number");
            }
            this.length = length;
        }
        public int GetLength()
        {
            return this.length;
        }
        public int GetVolume()
        {
            return this.length * this.height * this.width;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Length is {length} and height is {height} and width is {width} so the volume is {length * height * width}");
        }
    }
}
