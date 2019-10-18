using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UCL_OOP_I
{
    public class Trash
    {
        public DateTime Date_recycle { get; set; }

        public double Trash_weight { get; set; }

        public enum TrashType { Paper , Metal , Plastic , Glass }

        public enum TrashQuality { Excellent , Good, Average , Poor, Low}
    }
}
