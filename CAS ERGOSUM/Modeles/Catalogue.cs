using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAS_ERGOSUM.Methodes
{
    class Catalogue
    {
        #region Attributs
        private int _annee;
        public static ArrayList CollClasseCatalogue = new ArrayList();
        private Dictionary<Jouet, int> dicoQuantite;
        #endregion

        #region Constructeurs
        public Catalogue(int annee)
        {
            _annee = annee;
            Catalogue.CollClasseCatalogue.Add(this);
            this.DicoQuantite = new Dictionary<Jouet, int>();
        }
        #endregion

        #region getter-setter
        public int GetAnnee { get => _annee; set => _annee = value; }
        internal Dictionary<Jouet, int> DicoQuantite { get => dicoQuantite; set => dicoQuantite = value; }
        #endregion


        #region methode

        public int GetQuantiteDistribue()
        {
            int resultat = 0;
            foreach (KeyValuePair<Jouet, int> j in DicoQuantite)
            {
                resultat = j.Value + resultat;
            }
            return resultat;
        }

        #endregion
    }
}
