using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPMoyennes
{
    // Classes fournies par HNI Institut
    class Note
    {
        public int matiere { get; private set; }
        public float note { get; private set; }

        string[] matieres = new string[4];

        public Note(int m, float n)
        {
            matiere = m;
            note = n;
        }
    }
}
