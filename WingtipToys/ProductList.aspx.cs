using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;
using WingtipToys.Context;
using WingtipToys.Models;

namespace WingtipToys
{
    public partial class ProductList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // Pega todos os produtos da categoria informada
        public IQueryable<Product> GetProducts([QueryString("id")] int? categoryId)
        {
            // Instanciar o context
            ProductContext database = new ProductContext();

            IQueryable<Product> products = database.Products;

            // Verificar se o ID passado tem valor. Além de ser maior do que zero
            if(categoryId.HasValue && categoryId > 0)
            {
                products = products.Where(p => p.CategoryID == categoryId);
            }

            // Retornar todos os produtos que pertencem a categoria informada
            return products;
        }
    }
}