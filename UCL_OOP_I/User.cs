using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UCL_OOP_I
{
    public class User
    {
        #region Info
        public string Name { get; set; }
        public int Age{ get; set; }
        public int User_id{ get; set; }
        public Double Eco_points { get; set; }
        #endregion

        #region contructor
        public User()
        {
            Eco_points = 0;
        }
        #endregion

    }
}
