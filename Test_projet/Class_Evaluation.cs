using System;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Test_projet
{
    class Evaluation
    {
        //Attribut 


        //Propriété
        public Activity Activity { get; set; }

        //Constructeur
        public Evaluation(Activity activity)
        {
            Activity = activity;
        }

        //Méthode 
        public virtual int Note()
        {
            return -10;
        }
    }

    class Cote : Evaluation
    {
        //Attribut 
        private int note;

        //Constructeur 
        public Cote(Activity activity, int note) : base(activity)
        {
            this.note = note;
        }

        //Méthode
        public override int Note()
        {
            return note;
        }

        public void setNote(int value)
        {
            this.note = value;
        }

    }

    class Appreciation : Evaluation
    {
        //Attribut 
        private string appreciation;

        //Constructeur 
        public Appreciation(Activity activity, string appreciation) : base(activity)
        {
            this.appreciation = appreciation;
        }

        public override int Note()
        {

            //Dictionary<string, int> conversion = new Dictionary<string, int>() 
            //{ { "N", 4 }, { "C", 8 }, { "B", 12 }, { "TB", 16 }, { "X", 20 } };

            if (appreciation == "N")
            { return 4; };
            if (appreciation == "C")
            { return 8; };
            if (appreciation == "B")
            { return 12; };
            if (appreciation == "TB")
            { return 16; };
            if (appreciation == "X")
            { return 20; }

            else { return -10; };



        }
    }


}

