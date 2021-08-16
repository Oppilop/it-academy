﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqProfWilliamMenezes
{
    class Program
    {
        static void Main(string[] args)
        {
            //fonte de dados
            var listaProdutos = new List<Produto>()
            {
                
                new Produto{Id = 2, CategoriaId = 3, Nome = "sHORT", Status = true, Valor = 1},
                new Produto{Id = 3, CategoriaId = 1, Nome = "Video Game", Status = true, Valor = 99},
                new Produto{Id = 8, CategoriaId = 1, Nome = "TV", Status = true, Valor = 45},
                new Produto{Id = 1, CategoriaId = 3, Nome = "Camiseta", Status = true, Valor = 100},
                new Produto{Id = 5, CategoriaId = 1, Nome = "Microondas", Status = true, Valor = 90},
                new Produto{Id = 6, CategoriaId = 2, Nome = "Arroz", Status = true, Valor = 55},
                new Produto{Id = 7, CategoriaId = 2, Nome = "Feijao", Status = true, Valor = 12},
                new Produto{Id = 9, CategoriaId = 2, Nome = "Geladeira", Status = true, Valor = 10},
                new Produto{Id = 4, CategoriaId = 1, Nome = "Maquina de lavar", Status = false, Valor = 32},
            };

            var listaCategorias = new List<Categoria>()
            {
                new Categoria{Id = 1, Status = true, Nome = "Eletronicos"},
                new Categoria{Id = 2, Status = true, Nome = "Alimentos"},
                new Categoria{Id = 3, Status = true, Nome = "Vestuario"},
            };

            //criar consulta LINQ
            // 01 - Filtrar produtos por nome
            // var resultado = from produto in listaProdutos 
            //                 //where produto.Valor > 50 - utilizado para retornar valores acima de 50
            //                 where produto.Nome.ToLower() == "arroz".ToLower()
            //                 select produto;

            // 02 - Filtrar produtos pela primeira letra do nome
            // var resultado = from produto in listaProdutos 
            //                 where produto.Nome.ToLower().Substring(0, 1) == "m".ToLower()
            //                 select produto;

            // 03 - Filtrar produtos pela primeira letra do nome e status ativo
            // var resultado = from produto in listaProdutos 
            //                 where produto.Nome.ToLower().Substring(0, 1) == "m".ToLower() &&
            //                 produto.Status == false
            //                 select produto;

            // 04 - Ordenar os produtos por ID
            var resultado = from produto in listaProdutos 
                            where produto.Id > 1 && produto.Id < 6
                            orderby produto.Id descending
                            select produto;


            //executar a consulta
            foreach (var result in resultado)
            {
                Console.WriteLine($"{result.Id} | {result.Nome} | {result.Valor} | {result.CategoriaId}");              
            }
        }
    }

    class Produto 
    {
        public int Id {get; set;}
        public string Nome {get; set;}
        public bool Status {get; set;}
        public decimal Valor {get; set;}
        public int CategoriaId {get; set;}

    }

    class Categoria
    {
        public int Id {get; set;}
        public string Nome {get; set;}
        public bool Status {get; set;} 
    }
}
