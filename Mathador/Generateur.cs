using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathador
{
    class Generateur
    {
        private List<int> FirstDice = new List<int>();
        private List<int> SecondDice = new List<int>();
        private int TargetNumber;
        private Random random = new Random();

        public Generateur()
        {
            GenerateRandNumber(1, 13, 3, FirstDice);
            GenerateRandNumber(1, 20, 2, SecondDice);
            TargetNumber = random.Next(1, 101);
        }

        private void GenerateRandNumber(int min, int max, int repeat, List<int> liste)
        {
            int randNumber;

            for (int i = 0; i < repeat; i++)
            {
                randNumber = random.Next(min, max);
                liste.Add(randNumber);
            }
        }

        public override string ToString()
        {
            string myGenerator = "";
            FirstDice.ForEach(x => myGenerator += " "+x);
            myGenerator +=" / ";
            SecondDice.ForEach(x => myGenerator += " " + x);
            myGenerator += " => "+ TargetNumber;

            return myGenerator;
        }
    }
}
