using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_projet
{
    public class Evaluation
    {
        // Propriété
        public Activity Activity { get; private set; }

        //Constructeur
        public Evaluation(Activity activity)
        {
            this.Activity = activity;
        }

        // Méthode que l'on peut modifier
        public virtual int Note()
        {
            return -10;
        }
    }
}

