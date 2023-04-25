using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPMoyennes
{
    // Classes crée par TTI
    public class Classe
    { 
      
        public float MoyenneC
        {
            get { return 0; }
            internal set { }   // CS0273
                               // try the following line instead
                               // private set {}
        }
        public float MoyenneCm
        {
            get { return 0; }
            internal set { }   // CS0273
                               // try the following line instead
                               // private set {}
        }

        

        public  List<Eleve> eleves;
        

        public ConsoleCancelEventArgs(string lenom, string leprenom, float lamoy)
        {
            eleves = new List<Eleve>();
      
        }





        internal void ajouterEleve(string prenom, string nom)
        {
            throw new NotImplementedException();
        }

        internal void ajouterMatiere(string matiere)
        {
            throw new NotImplementedException();
        }
    }
}


