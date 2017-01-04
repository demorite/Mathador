using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace Mathador
{
    public class ObjectToSave
    {
        private JObject json;
        JArray coups = new JArray();
        private string usedOperators;

        public ObjectToSave(string pseudo, string tirage, int nombreCible)
        {
            usedOperators = "";
            json = new JObject();
            json["pseudo"] = pseudo;
            json["tirage"] = tirage;
            json["nombreCible"] = nombreCible;
            json["score"] = 0;
        }

        public void setScore(int score) => json["score"] = getScore() + score;
        public int getScore()
        {
            return Convert.ToInt32(json["score"]);
        }

        public void addCoups(int left, int right, char operateur)
        {
            coups.Add(Convert.ToString(left + operateur + right));
            json["coups"] = coups;

            switch (operateur)
            {
                case '+':
                    if (!usedOperators.Contains('+'))
                    {
                        usedOperators += "+";
                    }
                    setScore(1);
                    break;

                case '-':
                    if (!usedOperators.Contains('-'))
                    {
                        usedOperators += "-";
                    }
                    setScore(2);
                    break;

                case '*':
                    if (!usedOperators.Contains('*'))
                    {
                        usedOperators += "*";
                    }
                    setScore(1);
                    break;

                case '/':
                    if (!usedOperators.Contains('/'))
                    {
                        usedOperators += "/";
                    }
                    setScore(3);
                    break;
            }

            if (usedOperators.Contains('+') && usedOperators.Contains('-') && usedOperators.Contains('*') && usedOperators.Contains('/'))
            {
                setScore(13);
            }

            if (usedOperators.Length == 4)
            {
                restart();
            }
        }

        private void restart()
        {
            usedOperators = "";
        }

        public string toJson()
        {
            return json.ToString();
        }
    }

    public class Save
    {
        private string somethingToSave;
        const string path = @".\scores.json";
        private List<string> listOfScores;

        private ObjectToSave something;


        public Save(string pseudo, string tirage, int nombreCible)
        {
            something = new ObjectToSave(pseudo, tirage, nombreCible);
        }

        public void addCoup(int left, int right, char operateur) => something.addCoups(left, right, operateur);

        public void JsonSave()
        {
            somethingToSave = something.toJson();

            // Create a file to write to.
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.Write(somethingToSave);
            }
        }


    }
}
