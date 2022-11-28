using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public abstract class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        public abstract string GenerateQRCode();
        public abstract string GetDiscount(double discountPercent);

        public string? GetShortName()
        {
            return Name?.Substring(0, 5);
        }
    }
}
