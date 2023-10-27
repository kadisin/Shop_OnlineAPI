namespace Shop_OnlineAPI.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public User user { get; set; } = new User();
        public List<CartItem> CartItems { get; set; } = new();
        public bool Ordered { get; set; }
        public string OrderedOn { get; set; } = string.Empty;
    }
}
