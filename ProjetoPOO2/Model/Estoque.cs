using ProjetoOO.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPOO2.Model
{
    public  class Estoque
    {
        private int _capacidade = 1000;
        private int _ocupacao = 0;
        private float _montante = 0;
        public int Capacidade { get { return _capacidade; } }

        public int Ocupacao { get { return _ocupacao; } }

        public float Montante { get { return _montante; } }

        public void RegistrarEntrada(Produto produto)
        {
            if (produto.Quantidade > _capacidade)
            {
                throw new ArgumentException("O estoque não possui a quantidade de armazenar o produto requerido.");
            }
            _capacidade--;
            _ocupacao++;
            _montante += produto.CalcularTotalEstoque();
        }

        public void RegistrarSaida(Produto produto)
        {
            if (produto.Quantidade > _ocupacao)
            {
                throw new ArgumentException("O estoque não possui a quantidade de produtos requerido para retirada.");
            }

            _capacidade++;
            _ocupacao--;
            _montante -= produto.CalcularTotalEstoque();
        }

        public override string ToString()
        {
            return "Capacidade = " + _capacidade + " Ocupacao = " + _ocupacao + " Montante " + _montante + ")";
        }
    }
}
