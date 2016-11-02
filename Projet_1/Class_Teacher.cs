using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Cette classe permet d'initialiser les valeurs des variables firstname, lastname et salary.
// A note qu'on initialise pas réellement les valeurs des variables firstname et lastname dans cette classe...
//... étant donné qu'on les récupère de la classe mère (classe Person) où elles sont initialisées.

namespace Test_projet
{
    // Héritage -> Teacher dérive de Person
    public class Teacher : Person
    {
        //Attribut
        private int salary;

        //Propriété -> Créée vu que salary est private
        // Permet de retourner une valeur privée (normalement inaccessible)
        public int Salary
        {
            get
            {
                return salary;
            }

            set
            {
                salary = value;
            }
        }

        //Constructeur 
        //Réutilisation du code de la classe mère avec base
        public Teacher(string firstname, string lastname, int salary) : base(firstname, lastname)
        {
            // Lier la variable salary à la proriété Salary pour notre constructeur
            Salary = salary;
        }

    }
}
