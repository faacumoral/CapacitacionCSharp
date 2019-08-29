using System;
using System.Collections.Generic;
using System.Text;

namespace _2_AutoImplementedProperty
{
    public class User
    {
        #region
        private string _nombre1;
        public string getNombre()
        {
            return _nombre1;
        }
        public void setNombre(string pNombre)
        {
            _nombre1 = pNombre;
        }
        #endregion

        #region 
        private string _nombre2;
        public string Nombre2
        {
            get
            {
                return _nombre2;
            }
            set
            {
                _nombre2 = value;
            }
        }
        #endregion

        #region
        public string Nombre3 { get; set; }
        #endregion

        #region Operators
        public static bool operator +(User us1, User us2)
        {
            return true;
        }
        #endregion
    }
}
