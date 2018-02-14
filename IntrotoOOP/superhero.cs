using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntrotoOOP
{
    class superhero
    {
        private bool isSuperStrong;
        private string flight;
        private bool isHuman;
        private string costumeColor;
        private string heroName;

        public bool IsSuperStrong
        {
            get { return this.isSuperStrong; }
            set { this.isSuperStrong = value; }
        }
        public string Flight
        {
            get { return this.flight; }
            set { this.flight = value; }
        }

        public bool IsHuman
        {
            get { return this.isHuman; }
            set { this.isHuman = false; }
        }

        public string CostumeColor
        {
            get { return this.costumeColor; }
            set { this.costumeColor = value; }
        }

        public superhero()
        {
        }

        public superhero(string costumeColor, string Flight)
        {
            this.costumeColor = costumeColor;
            this.flight = Flight;
        }

        public superhero(bool IsHuman, bool IsSuperStrong)
        {
            this.isHuman = IsHuman;
            this.isSuperStrong = IsSuperStrong;
        }


        public void Recharge()
        { Console.WriteLine("get some sun!"); }

        public void SuperVillian()
        {
            if (isSuperStrong == true)
            {
                Console.WriteLine("time to fight");
            }
        }






        }
    }


