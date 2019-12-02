using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAS_ERGOSUM.Methodes
{
    class TrancheAge
    {
        #region Attributs
        public static ArrayList CollClassTrancheAge = new ArrayList();
        private int _code;
        private int _ageMin;
        private int _ageMax;
        #endregion

        #region Constructeurs
        public TrancheAge(int code, int ageMin, int ageMax)
        {
            Code = code;
            AgeMin = ageMin;
            AgeMax = ageMax;
            CollClassTrancheAge.Add(this);
        }
        #endregion

        #region Getters/Setters
        public int Code { get => _code; set => _code = value; }
        public int AgeMin { get => _ageMin; set => _ageMin = value; }
        public int AgeMax { get => _ageMax; set => _ageMax = value; }
        #endregion
    }
}
