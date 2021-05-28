using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WingtipToys.Models
{
    public class Product
    {
        // Número de identificação do produto (Chave primária)
        [ScaffoldColumn(false)]
        public int ProductID { get; set; }

        // Nome do produto
        [Required, StringLength(100), Display(Name = "Nome")]
        public string ProductName { get; set; }

        // Descrição do produto
        [Required, StringLength(1000), Display(Name = "Descrição")]
        public string Description { get; set; }

        // Caminho da imagem do produto
        public string ImagePath { get; set; }

        // Preço da unidiade do produto
        [Display(Name = "Preço")]
        public double? UnitPrice { get; set; }

        // Número de identificação da categoria a qual o produto pertence
        public int? CategoryID { get; set; }

        // Categoria a qual o produto pertence
        public virtual Category Category { get; set; }
    }
}

/* -- Anotações de Dados --
  * |__> Usado para descrever como validar a entrado do usuário,
  * especificar formatações e também dizer como esta tabela é modelada
  * 
  * ScaffoldColumn(true/false) => Ecibir ou não o atributo no formulário 
  * Required           => Campo obrigatório
  * StringLength       => Tamanho do campo
  * Display(Name = "") => Nome de exibução do campo
  */