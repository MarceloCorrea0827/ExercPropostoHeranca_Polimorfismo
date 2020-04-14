using System;
using System.Globalization;

namespace ExercPropHerPolim.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct()
        {
        }
        public UsedProduct(DateTime manufactureDate)
        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            return (Name + "(used) $" + Price.ToString("F2", CultureInfo.InvariantCulture) + "(ManufactureDate date: " + ManufactureDate.ToString("dd/MM/yyyy"));
        }
    }
}
