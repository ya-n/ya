using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1405_interfaces
{
    class Onibus : IMeioTransporte
    {
        public int Velocidade { get; set; }

        //chave para objeto Marca
        public int MarcaID { get; set; }
        public int Modelo { get; set; }

        //Propriedade de navegação
        public virtual Marca _Marca { get; set; }
        public void Acelerar()
        {
            Velocidade += 6;
        }

        public void Desacelerar()
        {
            Velocidade -= 3;
        }

        public string ImprimirInfo()
        {
            return "Ônibus, velocidade atual: " + Velocidade;
        }
    }
}
