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

        public enum TrashType { Paper , Metal , Plastic , Glass, Eletronics }

        public enum TrashQuality { Excellent , Average, Good, Low, Poor}

        public enum Paper { Papelão, Papel_comum, Revista, Jornal }

        public enum Metal { Alumínio, Cobre, Outros_metais}

        public enum Plastic { PET, Sacola, Isopor}

        public enum Glass { Vidro_cristal }

        public enum Eletronics { Pilhas, PC, Impressora, Celular}
    }
}
