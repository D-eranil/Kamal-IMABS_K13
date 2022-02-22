using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IMABS.Models
{
    public class BreadcrumbViewModel
    {
        public string LinkText { get; set; }
        public string LinkUrl { get; set; }
        public bool IsCurrentPage { get; set; }


        public BreadcrumbViewModel() { }
    }
}
