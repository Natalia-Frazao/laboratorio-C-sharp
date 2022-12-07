using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoOO.Model
{
    public class ProdutoIsento : Produto
    {
        public override float CalcularTotalEstoque()
        {
            return 0;
        }

        public override string ToString()
        {
            return "id " + Id + " nome " + Nome + ", preço unitário " + PrecoUnitario +
                ", quantidade em estoque " + Quantidade + ", categoria " + Categoria ;
        }
    }
}
