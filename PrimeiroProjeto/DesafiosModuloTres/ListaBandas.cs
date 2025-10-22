using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto.DesafiosModuloTres
{
    public static class ListaBandas
    {
        public static void RegistraBandasFavoritas() {
            List<string> listaBandasFavoritas = new List<string>();
            //List<string> listaBandasFavoritas = new (){ "Arctic Monkeys", "Tears For Fears", "Scorpions", "AHA" };
            listaBandasFavoritas.Add("Arctic Monkeys");
            listaBandasFavoritas.Add("Tears For Fears");
            listaBandasFavoritas.Add("Scorpions");
            listaBandasFavoritas.Add("AHA");

            for (int i = 0; i < listaBandasFavoritas.Count; i++) { 
                Console.WriteLine(listaBandasFavoritas[i]);
            }

            /*
            foreach (string banda in listaBandasFavoritas) { 
                Console.WriteLine(banda);
            }*/
        }
    }
}
