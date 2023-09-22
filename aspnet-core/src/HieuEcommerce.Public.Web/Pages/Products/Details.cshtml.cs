using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;
using HieuEcommerce.Public.ProductCategories;
using HieuEcommerce.Public.Products;

namespace HieuEcommerce.Public.Web.Pages.Products
{
    public class DetailsModel : PageModel
    {
        private readonly IProductAppService _productsAppService;
        private readonly IProductCategoriesAppService _productCategoriesAppService;
        public DetailsModel(IProductAppService productsAppService,
            IProductCategoriesAppService productCategoriesAppService)
        {
            _productsAppService = productsAppService;
            _productCategoriesAppService = productCategoriesAppService;
        }
        public ProductCategoryDto Category { get; set; }
        public ProductDto Product { get; set; }
        public async Task OnGetAsync(string categorySlug, string slug)
        {
            Category = await _productCategoriesAppService.GetBySlugAsync(categorySlug);
            Product = await _productsAppService.GetBySlugAsync(slug);
        }
    }
}