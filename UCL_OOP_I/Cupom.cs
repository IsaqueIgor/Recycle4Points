using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UCL_OOP_I {
    class Cupom {

        public Cupom()
        {
            //SIMULAÇÃO DE GERAR CUPONS
        }

        public static string cod_cupom()
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            var result = new string(Enumerable.Repeat(chars, 7).Select(s => s[random.Next(s.Length)]).ToArray());

            return result;
        }
    }
}
