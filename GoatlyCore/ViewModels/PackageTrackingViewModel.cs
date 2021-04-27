using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GoatlyCore.Models;

namespace GoatlyCore.ViewModels
{
    public class PackageTrackingViewModel
    {
        public IEnumerable<Order>? Orders { get; set; }
        public string? SelectedCarrier { get; set; }
        public string? SelectedTrackingNumber { get; set; }
    }
}
