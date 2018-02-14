using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntrotoOOP
{
    class Cat ////classes  are nouns
    {
        //I need STATES

        //states 
        //fields......private means only available in THIS class...nothing assigned, like a blueprint. Somewhat like adjectives.
        private string name;
        private int age;
        private string furColor;
        private bool isHungry;
        private string hairLength;

        //properties...has public access modifier= can be accessed in other class (example: program in this instance.  Name can be accessed in "program" class.  
        public string Name
        {
            get { return this.name; }//show me the value of name= get statement
            set { this.name = value; }//allows me to change the value of "name"......................."this" keyword....in this specific case when i am refering to this object i am referencing "this" object
        }
        public string HairLength
        {
            get { return this.hairLength; }
            set { this.hairLength = value; }
        }




        //I need BEHAVIORS

        //Constructors
        public Cat()
        {
            //default constructor. ALWAYS CREATE ONE
            //takes no parameters (nothing in paratheses)
            //can add 
            //this.name = "oz"; everytime you create a new cat object using default constructor, the value name will exist within.

        }
        public Cat(string name, int age, string furColor) ////methods are verbs
        {
            this.name = name;//name,age, furcolor are fields that belong to the object cat.  
            this.age = age;
            this.furColor = furColor;
        }

        public Cat (int age, bool isHungry)
        {
            this.age = age;
            this.isHungry = isHungry;
        }


        //methods


        public void Eat()
        {
            if (isHungry)///assumption = true, 
            { isHungry = false; }

            Console.WriteLine("Is the cat hungry? " + isHungry);
        }

        public void Meow()
        {
            Console.WriteLine("\a");
        }

        public string Hairball()
        {
            if (hairLength == "too long")
            {
                return (this.name + "has a hairball.");
            }
            else
            {
                return (this.name + "is nicely groomed.");
            }


        }


    }
}
