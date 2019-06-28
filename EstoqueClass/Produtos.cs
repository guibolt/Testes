using System;
using System.Collections.Generic;
using System.Text;

namespace EstoqueClass
{

    namespace EstoqueProdutos
    {
        class Produtos
        {
            public string nome;
            public double preco;
            public int quant;

            public double Valortotal()
            {

                return preco * quant;

            }

            public void AdicionarProdutos(int Quanti)
            {
                quant += Quanti;

            }

            public void RemoverProdutos(int Quanti)
            {
                quant -= Quanti;
            }

            public override string ToString()
            {
                return nome + ",R$ " + preco.ToString("F2", CultureInfo.InvariantCulture)
                    + ","
                    + quant + " Unidades ,Total R$" + Valortotal().ToString("F2", CultureInfo.InvariantCulture);
            }

        }
    }
}