using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HurtowniaFarmaceutycznaLibrary.Models
{
    public static class InventoryManager
    {
        public static List<Medicine> SortByQuantity(List<Medicine> products, bool ascending = true)
        {
            return ascending ? products.OrderBy(p => p.Quantity).ToList() : products.OrderByDescending(p => p.Quantity).ToList();
        }

        public static List<Medicine> SortByExpiration(List<Medicine> products, bool ascending = true)
        {
            return ascending ? products.OrderBy(p => p.ExpirationDate).ToList() : products.OrderByDescending(p => p.ExpirationDate).ToList();
        }
    }
}
