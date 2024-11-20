using System;
using System.Globalization;

namespace ConsoleApp1 {
    class Produto {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque() {

            return Preco * Quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public void AdicionarProdutos(int quantidade) {
            Quantidade += quantidade;
        }

        public override string ToString() {

            return Nome
                + ", $ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, TOTAL: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);

        }


    }
}
