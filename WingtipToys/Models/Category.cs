using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WingtipToys.Models
{
    public class Category
    {
        // Número de identificação da categoria
        [ScaffoldColumn(false)]
        public int CategoryID { get; set; }

        // Nome da categoria
        [Required, StringLength(100), Display(Name = "Nome")]
        public string CategoryName { get; set; }

        // Produtos associados a esta categoria
        public virtual ICollection<Product> Products { get; set; }
    }
}