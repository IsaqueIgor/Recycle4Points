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
        public double Age{ get; set; }
        public double User_id{ get; set; }
        public double Eco_points { get; set; }
        #endregion

        #region contructor
        public User()
        {
            Eco_points = 0;
        }
        #endregion

    }
}
