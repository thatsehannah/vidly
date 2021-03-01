﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly_V2.Models;

namespace Vidly_V2.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
        public string Title
        {
            get
            {
                return Customer != null && Customer.Id != 0 ? "Edit Customer" : "New Customer";
            }
        }

    }
}