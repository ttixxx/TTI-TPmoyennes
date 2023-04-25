using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;

namespace TPMoyennes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Création et Instanciation de la classe 6eme A
            Classe sixiemeA;
            sixiemeA = new Classe("6eme A");

            // Création et Instanciation de la classe 6eme B
            Classe sixiemeB;
            sixiemeB = new Classe("6eme B");

            // Ajout des élèves à la classe 6eme A
            sixiemeA.ajouterEleve("Jean", "RAGE");
            sixiemeA.ajouterEleve("Paul", "HAAR");
            sixiemeA.ajouterEleve("Sibylle", "BOQUET");
            sixiemeA.ajouterEleve("Annie", "CROCHE");
            sixiemeA.ajouterEleve("Alain", "PROVISTE");
            sixiemeA.ajouterEleve("Justin", "TYDERNIER");
            sixiemeA.ajouterEleve("Sacha", "TOUILLE");
            sixiemeA.ajouterEleve("Cesar", "TICHO");
            sixiemeA.ajouterEleve("Guy", "DON");

            // Ajout des élèves à la classe 6eme B
            sixiemeB.ajouterEleve("Bichel", "RAGE");
            sixiemeB.ajouterEleve("Bauline", "HAAR");
            sixiemeB.ajouterEleve("Bibyl", "BOQUET");
            sixiemeB.ajouterEleve("Bnne", "CROCHE");
            sixiemeB.ajouterEleve("Bl", "PROVISTE");
            sixiemeB.ajouterEleve("Bust", "TYDERNIER");
            sixiemeB.ajouterEleve("Bach", "TOUILLE");
            sixiemeB.ajouterEleve("Berise", "TICHO");
            sixiemeB.ajouterEleve("Buyguy", "DON");

            // Ajout de matières étudiées par la classe 6eme A
            sixiemeA.ajouterMatiere("Francais");
            sixiemeA.ajouterMatiere("Anglais");
            sixiemeA.ajouterMatiere("Physique/Chimie");
            sixiemeA.ajouterMatiere("Histoire");

            // Ajout de matières étudiées par la classe 6eme B
            sixiemeB.ajouterMatiere("Francais");
            sixiemeB.ajouterMatiere("Anglais");
            sixiemeB.ajouterMatiere("Physique/Chimie");
            sixiemeB.ajouterMatiere("Histoire");


            Random random = new Random();
            // Ajout de 5 notes à chaque élève et dans chaque matière
            for (int ieleve = 0; ieleve < sixiemeA.eleves.Count; ieleve++)
            {
                for (int matiere = 0; matiere < sixiemeA.matieres.Count; matiere++)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        sixiemeA.eleves[ieleve].ajouterNote(new Note(matiere, (float)((6.5 +
                       random.NextDouble() * 34)) / 2.0f));
                        // Note minimale = 3
                    }
                }
            }

            // Calcul la moyenne d'un eleve dans chaque matière 6eme A
            double cumul = 0;
            double nbe = 0;
            for (int ieleve = 0; ieleve < sixiemeA.eleves.Count; ieleve++)
            {
                for (int matiere = 0; matiere < sixiemeA.matieres.Count; matiere++)
                { 
                    for (int inote = 0; inote < Eleve.notes.Count; inote++)
                    {
                        nbe++;
                        cumul += Note[i];

                      if (nbe = 5)
                      {
                            Moyenne.Eleve.matiere = cumul / 5;
                            nbe = 0;
                            cumul = 0;

                      }

                    }
                }
            } 
            
            // Calcul la moyenne générale d'un eleve 6eme A

            for (int ieleve = 0; ieleve<sixiemeA.eleves.Count; ieleve++)
            {
                for (int matiere = 0; matiere < sixiemeA.matieres.Count; matiere++)
                {
                    cumul += Moyenne;
                    nbe++;

                 if (nbe = 4)
                 {
                        MoyenneG = cumul / 4;
                        nbe = 0;
                        cumul = 0;
                 }

                }
            }

            // Calcul la moyenne de la classe dans une matière (est 
            // la moyenne des moyennes de tous les élèves dans la matière) 

            for (int iclasse = 0; iclasse < classes.Count; iclasse++)
            {
                for (int matiere = 0; matiere < matieres.Count; matiere++)
                {
                    for (int ieleve = 0; ieleve < eleves.Count; ieleve++)
                    {

                        nbe++;
                        cumul += Moyenne;

                       if (nbe = Eleve.Lenght)
                       {
                            MoyenneCm = cumul / nbe;

                            nbe = 0;
                            cumul = 0;
                       }

                    }
                }
            }


            // La moyenne générale de la classe (est la moyenne 
            //  des moyennes de la classe par matière)

            for (int iclasse = 0; iclasse < classes.Count; ieleve++)
            {
                for (int matiere = 0; matiere < matieres.Count; matiere++)
                {
                    nbe++;
                    cumul += MoyenneCm;

                 if (nbe = matiere.Lenght)
                 {
                        MoyenneC = cumul / nbe ;

                        nbe = 0;
                        cumul = 0;
                 }

                    
                }
            }




            Eleve eleve = sixiemeA.eleves[6];
            // Afficher la moyenne d'un élève dans une matière
            Console.Write(eleve.prenom + " " + eleve.nom + ", Moyenne en " + sixiemeA.matieres[1] + " : " +
            eleve.Moyenne(1) + "\n");
            // Afficher la moyenne générale du même élève
            Console.Write(eleve.prenom + " " + eleve.nom + ", Moyenne Generale : " + eleve.Moyenne() + "\n");
            // Afficher la moyenne de la classe dans une matière
            Console.Write("Classe de " + sixiemeA.nomClasse + ", Moyenne en " + sixiemeA.matieres[1] + " : " +
            sixiemeA.Moyenne(1) + "\n");
            // Afficher la moyenne générale de la classe
            Console.Write("Classe de " + sixiemeA.nomClasse + ", Moyenne Generale : " + sixiemeA.Moyenne() + "\n");
            Console.Read();
        }
    }
}



