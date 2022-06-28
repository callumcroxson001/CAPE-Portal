using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CAPE.Models
{
    public class ViewModel
    {
        public Donor donor { get; set; }
        public Donation donation { get; set; }
        public Expenditure expenditure { get; set; }
    }
}