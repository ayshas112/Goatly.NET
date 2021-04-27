using System.Collections.Generic;
using GoatlyCore.Models;

#pragma warning disable CS8618 // Non-nullable field is uninitialized. Consider declaring as nullable.
namespace GoatlyCore.ViewModels
{
    public class ProductListViewModel
    {
        public IEnumerable<ProductItem> Products { get; set; }
        public IEnumerable<Category> ProductCategories { get; set; }
        public int? SelectedCategoryId { get; set; }
        public string? NameFilter { get; set; }

        public class ProductItem
        {
            public Product Product { get; set; }
            public string ImageUrl { get; set; }
        }
    }
}
