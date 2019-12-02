using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CAS_ERGOSUM.Methodes
{
    class Jouet
    {
        #region Attributs

            public static ArrayList CollClasseJouet = new ArrayList();

            private int _numéro;
            private string _libéllé;
            private Categorie _lesCategories;
            private TrancheAge _lesTranches;

        #endregion

        #region Constructeur

        public Jouet(int numéro, string libéllé, Categorie lesCategories, TrancheAge lesTranches)
        {
            Numéro = numéro;
            Libéllé = libéllé;
            Jouet.CollClasseJouet.Add(this);
            _lesCategories = lesCategories;
            _lesTranches = lesTranches;


        }

        #endregion

        #region Getter Setter

        public int Numéro { get => _numéro; set => _numéro = value; }
        public string Libéllé { get => _libéllé; set => _libéllé = value; }

        #endregion

        #region Methodes

        public string GetInfos()
        {
            return (_libéllé +";"+ this._lesCategories.GetLibelle() + ";" + this._lesTranches.AgeMax.ToString()+ ";" + this._lesTranches.AgeMin.ToString());
        }
        public bool Convient(int unAge)
        {
            if (unAge > _lesTranches.AgeMax && unAge < _lesTranches.AgeMin)
            {
                return false;
            }
           
            else
            {
                return true;
            }
        }


        #endregion

    }
}
