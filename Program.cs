using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TesteLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var numeros = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Dictionary<string, string> ListaEstado = new Dictionary<string, string>
            {
                { "Paraná", "Brasil" },
                { "Bahia", "Brasil" },
                { "Mato Grosso", "Brasil" },
                { "Catamarca", "Argentina" },
                { "Córdova", "Argentina" },
                { "La Pampa", "Argentina" },
                { "Dahuk", "Iraque" },
                { "Suleimânia", "Iraque" },
                { "Saladino", "Iraque" },
            };

            List<string> nomes = new List<string>
            {
                "Ricardo Souza",
                "Maria Antonieta",
                "Jessica Jonnes Lindona",
                "Pedro Alvares de Alencar Cabral"
            };

            var pessoas = new[]
            {
                "Carlos Alberto",
                "Maria do Carmo",
                "Maria Antonieta",
                "Hilda Furacão",
                "Bino o Caminhoneiro"
            };

            #region Método IEnumerable

            ////funcao de filtro que recebe um numero e retorna o que for filtrado
            //Func<int, bool> funcao = i => i > 2;

            //// resultado com os numeros filtrados pela função.
            //var resultado = numeros.Where(funcao);

            //foreach (var item in resultado)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion Método IEnumerable

            #region IQueryable<T>

            //var numeros1 = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }.AsQueryable();

            //// função que vai realizar o filtro
            //Expression<Func<int, bool>> funcao = f => f > 4;

            ////filtro funcao aplicado
            //var resultado = numeros1.Where(funcao);

            //foreach (var item in resultado)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion IQueryable<T>

            #region LINQ utilizando estilo de consulta "sintaxe de método" where

            //// filtro que retorna numeros maiores que 5 no ARRAY de numeros.
            //var numerosFiltrados = numeros.Where(n => n > 5);

            //foreach (var item in numerosFiltrados)
            //{
            //    Console.WriteLine(item);
            //}

            //// Exemplo para filtrar uma lista de nomes.

            ////filtro
            //var pessoasFiltradas = pessoas.Where(p => p.Contains("Maria"));

            //foreach (var item in pessoasFiltradas)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion LINQ utilizando estilo de consulta "sintaxe de método" where

            #region LINQ COUNT

            ////Contagem total
            //var countTotal = numeros.Count();

            ////Contagem com critérios
            //var countParcial = numeros.Count(n => n > 5);

            //Console.WriteLine(countTotal);
            //Console.WriteLine(countParcial);

            #endregion LINQ COUNT

            #region LINQ SUM

            //var somaTotal = numeros.Sum();
            //var somaComMultiplicacao = numeros.Sum(n => n * 2);

            //Console.WriteLine(somaTotal);
            //Console.WriteLine(somaComMultiplicacao);

            #endregion LINQ SUM

            #region LINQ – OrderBy and OrderByDescending

            ////ordem crescente
            //var numerosCrescente = numeros.OrderBy(n => n);

            //foreach (var item in numerosCrescente)
            //{
            //    Console.Write(item + ", ");
            //}
            //Console.WriteLine();
            //Console.WriteLine();
            ////ordem decrescente
            //var numerosOrdenados = numeros.OrderByDescending(n => n);

            //foreach (var item in numerosOrdenados)
            //{
            //    Console.Write(item + ", ");
            //}

            #endregion LINQ – OrderBy and OrderByDescending

            #region LINQ - Take e TakeWhile

            //// vai buscar até o numero 3
            //var items = numeros.Take(3);

            //foreach (var num in items)
            //{
            //    Console.WriteLine(num);
            //}

            ////TAKEWHILE busca até encontrar o critério
            //var itens = numeros.TakeWhile(n => n < 6);
            //foreach (var item in itens)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion LINQ - Take e TakeWhile

            #region FIRST e FirstOrDefault

            //var num = numeros.First();
            //Console.WriteLine(num);

            ////com filtro
            //var num2 = numeros.First(p => p > 6 && p < 9);
            //Console.WriteLine(num2);

            #endregion FIRST e FirstOrDefault

            #region Skip

            //var numeros2 = new[] { 1, 2, 3, 3, 3, 4, 5 };
            //var numerosPaginados = numeros2.Skip(3);

            //foreach (var item in numerosPaginados)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion Skip

            #region Concat

            //var colecao1 = new[] { 1, 2, 3 };
            //var colecao2 = new[] { 6, 7, 8 };

            //var numConcat = colecao1.Concat(colecao2);

            //foreach (var item in numConcat)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion Concat

            #region ElementAt

            //// busca o numero no index 4 = 5
            //var numero = numeros.ElementAt(4);
            //Console.WriteLine(numero);

            #endregion ElementAt

            #region Single e SingleOrDefault

            //var numeros2 = new[] { 1, 2, 3, 3, 4, 5, 5, 6 };

            //try
            //{   //filtro que vai gerar uma exceção pois tem dois 3
            //    var numero = numeros2.Single(p => p == 3);
            //    Console.WriteLine(numero);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message + " existem dois numeros 3 na lib");
            //}

            //// filtro que não gera exceção pois só tem um numero 6 na biblioteca
            //var numero1 = numeros2.Single(p => p == 6);
            //Console.WriteLine("somente um numero " + numero1 + " na lib");

            #endregion Single e SingleOrDefault

            #region Select

            //// p vai receber os numeros e ele será uma nova coleção, com descrição e ID herdada de numeros.
            //var categorias = numeros.Select(p => new
            //{
            //    Id = p,
            //    Descricao = $"Descricao {p}"
            //});

            //foreach (var item in categorias)
            //{
            //    var descricao = $"Categoria: {item.Id} - {item.Descricao}";
            //    Console.WriteLine(descricao);
            //}

            #endregion Select

            #region GROUP

            ////filtro lista de estado pelo Pais
            //var resultado = ListaEstado.GroupBy(e => e.Value);

            //foreach (var pais in resultado)
            //{
            //    //pega os países da lista
            //    Console.WriteLine($"[] {pais.Key}");

            //    //pega os estados de cada país
            //    foreach (var estado in pais)
            //    {
            //        Console.WriteLine($"          - {estado.Key}");
            //    }
            //}

            #endregion GROUP

            #region Agregate

            //var resultado = nomes.Aggregate((maior, proximo) =>
            //{
            //    return maior.Length > proximo.Length ? maior : proximo;
            //});

            //Console.WriteLine($"{resultado} é o maior nome da lista");

            #endregion Agregate

            Console.ReadLine();
        }
    }
}