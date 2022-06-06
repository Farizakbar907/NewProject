using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectPromotion.Models
{
    public class PromotionViewModel
    {
        public Promotion Promotion { get; set; }
        public IEnumerable<Stores> StoresViewModel { get; set; }
    }
}
