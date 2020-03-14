using System;
using System.Collections.Generic;
using APM.Utilities;

namespace APM.SL
{
    public class Discount
    {
        public int DiscountId { get; private set; }
        //After enabling nullable feature - we can either set non-null default value or use nullable type - ? oprator
        public string DiscountName { get; set; } = string.Empty;

        public decimal? PercentOff { get; set; }

        // ... Discount details

        public Discount? FindDiscount(List<Discount>? discounts, string discountName)
        {
            if (discounts is null) return null;

            var foundDiscount = discounts.Find(d => d.DiscountName == discountName);

            return foundDiscount;
        }

        public Discount? FindDicountWithException(List<Discount>? discounts, string discountName)
        {
            if (discounts is null) throw new ArgumentException("No discounts found");

            var foundDiscount = discounts.Find(d => d.DiscountName == discountName);

            if (foundDiscount is null)
                throw new DiscountNotFoundException("Discount not found");
            return foundDiscount;
        }
    }
}
