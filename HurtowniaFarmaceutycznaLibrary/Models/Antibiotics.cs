using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HurtowniaFarmaceutycznaLibrary.Models
{
    public class Antibiotic : Medicine
    {
        public Antibiotic(string name, int quantity, DateTime expirationDate)
            : base(name, quantity, expirationDate)
        {
        }

        public override void UpdateQuantity(int amount)
        {
            // np. specjalna logika: antybiotyki nie mogą mieć ilości ujemnej
            if (Quantity + amount >= 0)
                base.UpdateQuantity(amount);
        }
    }
}
