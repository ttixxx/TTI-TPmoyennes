using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPMoyennes
{
    // Classes crée par TTI
    public class Eleve
    {

        public string nom { get; private set; }
        public string prenom { get; private set; }
        public float Moyenne { get; private set; }
        public float MoyenneG { get; private set; }
        
        // constructeur
        public Eleve(string lenom, string leprenom, float lamoy)
        {
            nom = lenom;
            prenom = leprenom;
            Moyenne = lamoy;

        }
        
        // Association de classe Eleve et classe
        private List<Note> Notes;
        public Note(int m, float n)
        {
            Notes = new List<Note>();
        }




    }
}