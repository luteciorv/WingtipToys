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
    public partial class ProductDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<Product> GetProduct([QueryString("productId")] int? productId)
        {
            // Instanciar um contexto
            ProductContext database = new ProductContext();

            // Pegar os produtos
            IQueryable<Product> product = database.Products;

            // Realizar a consulta
            product = productId.HasValue && productId > 0 ? product.Where(p => p.ProductID == productId) : null;

            // Retornar o produto associado ao Id passado
            return product;
        }
    }
}