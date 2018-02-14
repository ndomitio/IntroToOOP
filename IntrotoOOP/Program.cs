using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntrotoOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat firstCat = new Cat();///using the default constructor (has nothing in parantheses)
            firstCat.Name = "Mr. Fuzzy";//.name is the "name property"

            Cat secondCat = new Cat("Midnight", 14, "black"); // these values we assgined only exist in secondcat "object".

            Console.WriteLine(firstCat.Name);
            Console.WriteLine(secondCat.Name);

            firstCat.Eat();   //the "dot" . operator is calling Eat method to the firstcat object  
            secondCat.Meow();

            firstCat.HairLength = "nice and short";
            secondCat.HairLength = "too long";

            Console.WriteLine(firstCat.Hairball());
            Console.WriteLine(secondCat.Hairball());
            
        }
    

    }
}
