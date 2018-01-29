using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntrotoOOP
{
    class Dog
    {//fields


        private string hairLength;
        private double height;
        private string runningSpeed;
        private double weight;
        

        //properties
        public string HairLength
        {
            get { return this.hairLength; }
            set { this.hairLength = value; }
        }
        public double Height
        {
            get { return this.height; }
            set { this.height = value; }
        }

        public string RunningSpeed
        {
            get { return this.runningSpeed; }
            set { this.runningSpeed = value; }
        }

        public double Weight
        {
            get { return this.weight; }
            set { this.weight = value; }
        }


        // Construct
        public Dog ()
        { }
        
        public Dog (string hairlength, double height, string runningSpeed, double weight)
        { this.hairLength = hairlength;
            this.height = height;
            this.runningSpeed = runningSpeed;
            this.weight = weight;
        }

        public void Run ()
        { }

        public void Bark ()
        { Console.WriteLine("\a"); }

        public void Potty ()
        { }

        public void Cuddle ()
        { }






         
        
        
        
}
    }

