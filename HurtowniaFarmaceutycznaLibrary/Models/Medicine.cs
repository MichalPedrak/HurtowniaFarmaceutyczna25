using System.Text.Json.Serialization;

namespace HurtowniaFarmaceutycznaLibrary.Models
{
    public enum MedicineType
    {
        Antybiotyk,
        Przeciwbolowa
    }
    
    public abstract class Medicine : IProduct
    {
        private string _name;
        private int _quantity;
        private DateTime _expirationDate;
        private MedicineType _type;

        public string Name => _name;
        public int Quantity => _quantity;
        public DateTime ExpirationDate => _expirationDate;
        public MedicineType Type => _type;
        

        public Medicine(string name, int quantity, DateTime expirationDate, MedicineType type)
        {
            _name = name;
            _quantity = quantity;
            _expirationDate = expirationDate;
            _type = type;      
        } 


        public virtual void UpdateQuantity(int amount)
        {
            _quantity += amount;
        }

        public override string ToString()
        {
            return $"{Name} - {Quantity} szt. (do {ExpirationDate:yyyy-MM-dd})";
        }
    }
}
