using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaPrimerServicioWCF
{
    public class MetodosVariosClass : IMetodosVariosContract
    {
        public int GetNumeroDoble(int numero)
        {
            return numero * 2;
        }

        public string GetSaludo(string nombre)
        {
            return "Mi primer Wcf, " + nombre;
        }

        public List<int> GetTablaMultiplicar(int numero)
        {
            List<int> results = new List<int>();
            for(int i = 1; i <= 10; i++)
            {
                int op = numero * i;
                results.Add(op);
            }
            return results;
        }

        public string MetodoInvisible()
        {
            return "no sirvo";
        }
    }
}
