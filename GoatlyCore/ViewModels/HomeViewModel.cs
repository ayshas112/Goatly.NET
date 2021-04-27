using System.Collections.Generic;
using GoatlyCore.Models;

#pragma warning disable CS8618 // Non-nullable field is uninitialized. Consider declaring as nullable.
namespace GoatlyCore.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Product> TopProducts { get; set; }
    }
}