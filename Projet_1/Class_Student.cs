using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Cette classe permet 

namespace Test_projet
{
    // la classe Student dérive de Person
    public class Student : Person
    {
        //Attribut 
        // En général, pour déclarer une liste -> List <int> cours = new List <int> ();
        public List<Evaluation> cours = new List<Evaluation> { };

        //Propriété
        public List<Evaluation> Cours
        {
            get
            {
                return Cours;
            }

            set
            {
                cours = value;
            }

        }

        //Constructeur 
        public Student(string firstname, string lastname) : base(firstname, lastname)
        {
        }

        //Methode
        // Ajouter une "evaluation" à la liste cours (qui est de type Evaluation).
        public void AddEvaluation(Evaluation evaluation)
        {
            cours.Add(evaluation);
        }

        // Retourner la moyenne des cotes de la liste cours.
        // Remarque : Note() est définit dans la classe Evaluation.
        public float Average()
        {
            float sum = 0;
            for (int i = 0; i < cours.Count(); i++)
            {
                sum += cours[i].Note();
            }

            float res = (sum / cours.Count());
            return res;
        }   


        // Rédiger le bulletin
        public void Bulletin()
        {
            string Carnet = "";
            double var = Average();
            for (int i = 0; i < cours.Count(); i++)
            {
                Carnet += cours[i].Activity.Name;
                Carnet += " : ";
                Carnet += cours[i].Note();
                Carnet += "\n";
            }

            Console.Write(Firstname + " " + Lastname + "\n \n" + Carnet + "\n" + "Moyenne : ");
            string outString = Average().ToString("####0.00");
            Console.WriteLine(outString);
            Console.WriteLine("");
            Console.ReadKey();
        }



    }
}
