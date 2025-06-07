using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HurtowniaFarmaceutycznaLibrary.Models
{
    public class PainKiller : Medicine
    {
        public PainKiller() : base(default!, 0, default, default) { } 

        [JsonConstructor]
        public PainKiller(string name, int quantity, DateTime expirationDate, MedicineType type)
            : base(name, quantity, expirationDate, MedicineType.Przeciwbolowa)
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