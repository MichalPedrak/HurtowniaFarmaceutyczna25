namespace HurtowniaFarmaceutycznaLibrary.Models
{
    public class Medicine : IProduct
    {
        private string _name;
        private int _quantity;

        public string Name => _name;
        public int Quantity => _quantity;
        public DateTime ExpirationDate { get; protected set; }

        public Medicine(string name, int quantity, DateTime expirationDate)
        {
            _name = name;
            _quantity = quantity;
            ExpirationDate = expirationDate;
        }

        // [Polimorfizm] - metoda może być przesłaniana
        public virtual void UpdateQuantity(int amount)
        {
            _quantity += amount;
        }

        public override string ToString() => $"{Name} - {Quantity} szt. (do {ExpirationDate:yyyy-MM-dd})";
    }
}
