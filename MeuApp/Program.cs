using System;

namespace MeuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var mouse = new Product(1, "Mouse Logitech", 123.50, ETipoProduto.Produto);
            var manutencao = new Product(2, "Manutenção Elétrica", 250.00, ETipoProduto.Servico);

            Console.WriteLine(mouse.Id);
            Console.WriteLine(mouse.Nome);
            Console.WriteLine(mouse.Preco);
            Console.WriteLine((int)mouse.Tipo);
        }
    }

    struct Product
    {
        public Product(int id, string nome, double preco, ETipoProduto tipo)
        {
            Id = id;
            Nome = nome;
            Preco = preco;
            Tipo = tipo;
        }
        public int Id;
        public string Nome;
        public double Preco;
        public ETipoProduto Tipo;
        public double PrecoEmDolar(double dolar)
        {
            return Preco * dolar;
        }
    }

    enum ETipoProduto
    {
        Produto = 1,
        Servico = 2
    }
}
