using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookWeb.Models.ViewModels
{
    public class ProductVM
    {
        public Product Product = new();
        public IEnumerable<SelectListItem> CategoryList { get; set; }  
        public IEnumerable<SelectListItem> CoverTypeList {get; set; }   
    }
}
