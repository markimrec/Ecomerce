using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyEcomerce.Models;

namespace MyEcomerce.Controllers
{
    public class ProdutosController : Controller
    {
        public IActionResult Index(int id = 0)
        {
            var produtoParaRetornar = new Produto
            {
                Id = 11,
                IdFornecedor = 3,
                Name = "Produto do markim"
            };


            var meuProduto = new Produto();
            meuProduto.Id = 11;
            meuProduto.IdFornecedor = 3;
            meuProduto.Name = "Produto";




            return View(produtoParaRetornar);
        }

        public IActionResult Criar()
        {
            return View();
        }
    }
}