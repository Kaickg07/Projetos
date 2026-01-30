using System;
using Syste.Linq;

namespace Steam
{
    public class Cliente
    {
        public string Nome{get;set;}
        public int Id{get;set;}
        public int Nivel{get;set;}

        public Cliente(string nome,int id,int nivel)
        {
            Nome = nome;
            Id = id;
            Nivel = nivel;
        }
        public string ListarClientes()
        {
            return $"O Cliente {Nome} pertencente ao ID:{Id} chegou ao nivel {Nivel} em sua conta";
        }
    }
    
    public class Jogo
    {
        public string Nome{get;set;}
        public int Preco{get;set;}

        public Jogo(string nome,int preco)
        {
            Nome = nome;
            Preco = preco;
        }
        public string ListarJogos()
        {
            return $"O jogo {Nome} esta com o preco de {Preco} reais";
        }
    }

    public class Compra
    {
        public Cliente Cliente{get;set;}
        public Jogo Jogo{get;set;}
        public DateTime DataCompra{get;set;}

        public Compra(Cliente cliente,Jogo jogo)
        {
            Jogo = jogo;
            Cliente = cliente;
            DataCompra = DateTime.Now;
        }

        public string ListarCompras()
        {
            return $"O cliente {Cliente.Nome} comprou o jogo {Jogo.Nome} no dia {DataCompra}";
        }
    }

    
    class Program
    {
        static void Main(string [] args)
        {
            Console.WriteLine("Sistema Steam iniciando...");
            Console.WriteLine("\nClientes Cadastrados:");

            Cliente meucliente1 = new Cliente("Kaick Gomes",467236,25);
            Cliente meucliente2 = new Cliente("Davy Jones",872382,999);
            Cliente meucliente3 = new Cliente("Victor Kratos",362782,534);
            Cliente meucliente4 = new Cliente("Games Edu",372642,1);
            Cliente meucliente5 = new Cliente("Luan Gameplay",873622,100);

            Jogo meujogo1 = new Jogo("God of War",100);
            Jogo meujogo2 = new Jogo("Elden Ring",220);
            Jogo meujogo3 = new Jogo("Gta 6",600);
            Jogo meujogo4 = new Jogo("Resident Evil 2 Remake",150);
            Jogo meujogo5 = new Jogo("The Last of Us",80);

            Compra minhacompra1 = new Compra(meucliente1,meujogo2);
            Compra minhacompra2 = new Compra(meucliente3,meujogo1);
            Compra minhacompra3 = new Compra(meucliente2,meujogo4);
            Compra minhacompra4 = new Compra(meucliente4,meujogo5);
            Compra minhacompra5 = new Compra(meucliente5,meujogo3);
            

            Cliente [] todosclientes = {meucliente1,meucliente2,meucliente3,meucliente4,meucliente5};
            foreach (var c in todosclientes)
            {
                Console.WriteLine(c.ListarClientes());
            }

            Console.WriteLine("\nJogos Cadastrados:");
            Jogo [] todosjogos = {meujogo1,meujogo2,meujogo3,meujogo4,meujogo5};
            foreach (var j in todosjogos)
            {
                Console.WriteLine(j.ListarJogos());
            }

            Console.WriteLine("\nExtrato de Compras");
            Compra [] todascompras = {minhacompra1,minhacompra2,minhacompra3,minhacompra4,minhacompra5};
            foreach (var co in todascompras)
            {
                Console.WriteLine(co.ListarCompras());
            }
            

        }
    }

}