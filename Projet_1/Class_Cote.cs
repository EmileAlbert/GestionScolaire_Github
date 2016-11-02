using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_projet
{
    public class Cote : Evaluation
    {
        // Attribut
        private int note;

        // Constructeur
        public Cote(Activity activity) : base(activity)
        {
        }

        // Méthode qui permet d'ajouter une note
        public void setNote(int note)
        {
            this.note = note;
        }

        // Méthode -> Même méthode que dans la classe Evaluation mais modifiée !
        // Elle retourne dans ce cas-ci une note et non pas -10
        public override int Note()
        {
            return note;
        }
    }
}

