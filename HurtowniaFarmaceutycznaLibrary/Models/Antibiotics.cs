using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HurtowniaFarmaceutycznaLibrary.Models
{
    public class Antibiotic : Medicine
    {
        public Antibiotic(string name, int quantity, DateTime expirationDate, MedicineType type)
            : base(name, quantity, expirationDate, MedicineType.Antybiotyk)
        {
        }

        public override void UpdateQuantity(int amount)
        {
            if (Quantity + amount >= 0)
            {
                base.UpdateQuantity(amount);
            }
            else
            {
                throw new InvalidOperationException("Ilość antybiotyku nie może być ujemna");
            }
               
        }
    }
}
