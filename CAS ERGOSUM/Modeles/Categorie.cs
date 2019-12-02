using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAS_ERGOSUM.Methodes
{
    class Categorie
    {
        #region Attributs
        public static ArrayList CollClasseCategorie = new ArrayList();

        private int _code;
        private string _libelle;
        private ArrayList _lesJouets;
        #endregion

        #region Constructeurs
        public Categorie (int leCode, string leLibelle) 
        {
            _code=leCode;
            _libelle=leLibelle;

            _lesJouets=new ArrayList();

            Categorie.CollClasseCategorie.Add(this);
        }
        #endregion

        #region Getter/Setter
        
        public int Code { get => _code; set => _code = value; }
        public string Libelle { get => _libelle; set => _libelle = value; }
        #endregion

        #region Methodes
        public int GetCode()
        {
            return Code;
        } 

        public string GetLibelle()
        {
            return Libelle;
        }

      
        #endregion
    

    }
}
