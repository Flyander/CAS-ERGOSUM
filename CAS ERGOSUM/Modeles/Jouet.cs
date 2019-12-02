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

        #endregion

        #region Constructeur

        public Jouet(int numéro, string libéllé)
        {
            Numéro = numéro;
            Libéllé = libéllé;
        }

        #endregion

        #region Getter Setter

        public int Numéro { get => _numéro; set => _numéro = value; }
        public string Libéllé { get => _libéllé; set => _libéllé = value; }

        #endregion

        #region Methodes

        public

        #endregion

    }
}
