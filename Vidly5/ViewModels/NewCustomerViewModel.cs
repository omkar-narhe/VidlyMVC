using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly5.Models;

namespace Vidly5.ViewModels
{
    public class NewCustomerViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
    }
}