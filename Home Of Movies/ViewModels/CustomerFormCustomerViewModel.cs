using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Home_Of_Movies.Models;

namespace Home_Of_Movies.ViewModels
{
    public class CustomerFormCustomerViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
    }
}