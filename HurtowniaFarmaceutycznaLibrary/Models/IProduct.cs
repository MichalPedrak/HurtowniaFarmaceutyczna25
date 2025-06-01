using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HurtowniaFarmaceutycznaLibrary.Models
{
    public interface IProduct
    {
        string Name { get; }
        int Quantity { get; }
        DateTime ExpirationDate { get; }

        void UpdateQuantity(int amount);
    }
}
