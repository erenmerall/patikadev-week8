using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BasicMvcProject.Models;

namespace BasicMvcProject.ViewModels
{
    public class CustomerOrderViewModel 
    {
        public Customer Customer { get; set; }
        public List<Order> Orders { get; set; }
    }
}