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

        public string nom { get; }
        public string prenom { get; }
        public static double Moyenne;
        public static double MoyenneG; 
        
        // constructeur
        public Eleve(string lenom, string leprenom, float lamoy)
        {
            nom = lenom;
            prenom = leprenom;
            Moyenne = lamoy;

        }

        internal void ajouterNote(string note)
        {
            throw new NotImplementedException();
        }






        
        public List<Note> Notes;
        public Note(int m, float n)
        {
            Notes = new List<Note>();
        }

        var notes = new List<string>();


    }
}