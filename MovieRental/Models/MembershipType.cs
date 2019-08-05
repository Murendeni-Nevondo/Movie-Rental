using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieRental.Models
{
    public class MembershipType
    {
        public int Id { get; set; }
        public short SignUpFee { get; set; }
        public short DurationInMonths { get; set; }
        public int DiscountRate { get; set; }
        public string Name { get; set; }
    }
}