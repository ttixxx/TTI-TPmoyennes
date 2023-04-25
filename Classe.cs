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
      
        public float MoyenneC { get; private set; }
        public float MoyenneCm { get; private set; }

        // Association de classe Eleve et classe

        private List<Eleve> Eleves;
        public Eleve(string lenom, string leprenom, float lamoy)
        {
            Eleves = new List<Eleve>();
        }




        // création d'une liste d'élève par classe
        var listeleve = new List<string> { }

        // création d'une liste d'élève par classe
        var listemat = new List<string> { }

        // Description des méthodes
        public void ajouterEleve()
        {
         listeleve.Add();

        }
        public void ajouterMatiere()
        {
         listemat.Add();

        }




    }
}


