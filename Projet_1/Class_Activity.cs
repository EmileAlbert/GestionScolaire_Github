using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Cette classe permet d'initialiser les valeurs des variables ects, name, code et teacher.

namespace Test_projet
{
    public class Activity
    {
        //Attribut 
        public int ects;
        public string name;
        public string code;
        // objet de la classe teacher
        public Teacher teacher;

        //Propriétés
        public int ECTS
        {
            get
            {
                return ects;
            }

            set
            {
                ects = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Code
        {
            get
            {
                return Code;
            }

            set
            {
                code = value;
            }
        }

        public Teacher Teacher
        {
            get
            {
                return teacher;
            }

            set
            {
                teacher = value;
            }
        }

        //Constructeur 
        public Activity(int ects, string name, string code, Teacher teacher)
        {
            ECTS = ects;
            Name = name;
            Code = code;
            Teacher = teacher;
        }


    }
}
