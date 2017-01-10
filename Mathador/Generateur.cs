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
        public int TargetNumber { get; private set; }
        private Random random = new Random();

        public string solution;

        public Generateur()
        {

            int[] table = new int[5];


            do
            {
                GenerateRandNumber(1, 13, 3, FirstDice);
                GenerateRandNumber(1, 20, 2, SecondDice);
                TargetNumber = random.Next(1, 101);

                table[0] = FirstDice[0];
                table[1] = FirstDice[1];
                table[2] = FirstDice[2];
                table[3] = SecondDice[0];
                table[4] = SecondDice[1];
            } while (!Solveur.solve(table, TargetNumber));
        }

        private void GenerateRandNumber(int min, int max, int repeat, List<int> liste)
        {
            liste.RemoveAll(x => liste.Remove(x));
            int randNumber;

            for (int i = 0; i < repeat; i++)
            {
                randNumber = random.Next(min, max+1);
                liste.Add(randNumber);
            }
        }

        public List<int> getDices()
        {
            List<int> dices = new List<int>();
            FirstDice.ForEach(x => dices.Add(x));
            SecondDice.ForEach(x => dices.Add(x));
            return dices;
        }

        public override string ToString()
        {
            var myGenerator = Tirage();
            myGenerator += " => "+ TargetNumber;

            return myGenerator;
        }

        public string Tirage()
        {
            string myGenerator = "";
            FirstDice.ForEach(x => myGenerator += " " + x);
            myGenerator += " / ";
            SecondDice.ForEach(x => myGenerator += " " + x);
            return myGenerator;
        }
    }
}
